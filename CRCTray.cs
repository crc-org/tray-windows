using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using CRCTray.Communication;
using CRCTray.Helpers;

namespace CRCTray
{
    internal class CRCTray : ApplicationContext
    {
        private TrayIcon trayIcon;

        // MenuStrip Items
        private ToolStripLabel status;
        private ToolStripItem detailedStatusMenu;
        // cluster commands
        private ToolStripItem startMenu;
        private ToolStripItem stopMenu;
        private ToolStripItem deleteMenu;
        // application commands
        private ToolStripItem aboutMenu;
        private ToolStripItem exitMenu;
        private ToolStripItem settingsMenu;
        // developer commands
        private ToolStripItem openWebConsoleMenu;
        private ToolStripItem copyOCLoginCommand;
        private ToolStripItem copyOCLoginForDeveloperMenu;
        private ToolStripItem copyOCLoginForKubeadminMenu;


        // Forms
        private Form settingsWindow;
        private Form about;
        private Form statusForm;

        private readonly double pollInterval = 5000; // 5 seconds poll interval

        private readonly string InitialState = @"Stopped";


        // Initialize tray
        public CRCTray()
        {
            trayIcon = new TrayIcon(Resource.ocp_logo, "CodeReady Containers");

            StartDaemon();

            // Keep polling status and updating the statusMenuItem
            var statusPollingTimer = new System.Timers.Timer(pollInterval);
            statusPollingTimer.Enabled = true;
            statusPollingTimer.Elapsed += pollStatusTimerEventHandler;

            Tasks.StatusChanged += UpdateReceived;
            Tasks.StopReceived += StopReceived;
            Tasks.DeleteReceived += DeleteReceived;

            SetContextMenu();
        }

        private void StartDaemon()
        {
            _ = TaskHelpers.TryTask(() => DaemonLauncher.Start(QuitApp));
        }

        private static void pollStatusTimerEventHandler(object source, System.Timers.ElapsedEventArgs e)
        {
            TaskHelpers.TryTask(Tasks.Status).NoAwait();
        }

        // populate the context menu for tray icon
        private void SetContextMenu()
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.AccessibleName = "menu";

            // Status Menu
            status = new ToolStripLabel();
            SetStatusText(InitialState); //TODO: actually "Unknown"
            status.Enabled = false;
            cm.Items.Add(status);

            cm.Items.Add(new ToolStripSeparator());
            // Detailed status menu
            detailedStatusMenu = cm.Items.Add(@"Status and Logs");
            detailedStatusMenu.AccessibleName = "status-detailed";
            detailedStatusMenu.Click += ShowDetailedStatusForm;
            cm.Items.Add(new ToolStripSeparator());

            // Start Menu
            startMenu = cm.Items.Add(@"Start");
            startMenu.AccessibleName = "start";
            startMenu.Click += StartMenu_Click;

            // Stop Menu
            stopMenu = cm.Items.Add(@"Stop");
            stopMenu.AccessibleName = "stop";
            stopMenu.Click += StopMenu_Click;

            // Delete Menu
            deleteMenu = cm.Items.Add(@"Delete");
            deleteMenu.AccessibleName = "delete";
            deleteMenu.Click += DeleteMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // Open web console menu
            openWebConsoleMenu = cm.Items.Add(@"Launch Web Console");
            openWebConsoleMenu.AccessibleName = "open-web-console";
            openWebConsoleMenu.Click += OpenWebConsoleMenu_Click;

            // Copy oc login command
            copyOCLoginCommand = cm.Items.Add(@"Copy OC Login Command");
            copyOCLoginCommand.AccessibleName = "copy-oc-login";

            // Copy oc login command: developer
            copyOCLoginForDeveloperMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Developer");
            copyOCLoginForDeveloperMenu.AccessibleName = "developer";
            copyOCLoginForDeveloperMenu.Click += CopyOCLoginForDeveloperMenu_Click;
            // Copy oc login command: kubeadmin
            copyOCLoginForKubeadminMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Kubeadmin");
            copyOCLoginForKubeadminMenu.AccessibleName = "kubeadmin";
            copyOCLoginForKubeadminMenu.Click += CopyOCLoginForKubeadminMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // Settings menu
            settingsMenu = cm.Items.Add(@"Settings");
            settingsMenu.AccessibleName = "settings";
            settingsMenu.Click += SettingsMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // About menu
            aboutMenu = cm.Items.Add(@"About");
            aboutMenu.AccessibleName = "about";
            aboutMenu.Click += ShowAboutForm;

            // Exit menu
            exitMenu = cm.Items.Add(@"Exit");
            exitMenu.AccessibleName = "exit";
            exitMenu.Click += ExitMenu_Click;

            // set context menu on trayicon
            trayIcon.ContextMenuStrip = cm;

            // enable items
            aboutMenu.Enabled = true;
            detailedStatusMenu.Enabled = true;
        }

        private void SettingsMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.OpenPreferences).NoAwait();

            if (settingsWindow == null)
                settingsWindow = new SettingsForm();

            if (!settingsWindow.Visible)
                settingsWindow.Show();

            settingsWindow.Focus();
        }

        async private void CopyOCLoginForKubeadminMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.CopyOCLoginForAdmin).NoAwait();

            try
            {
                var consoleResult = await Task.Run(Tasks.LoginForKubeadmin);
                Clipboard.SetText(string.Format("oc.exe login -u kubeadmin -p {0} {1}",
                    consoleResult.ClusterConfig.KubeAdminPass, consoleResult.ClusterConfig.ClusterAPI));
            }
            catch
            {
                TrayIcon.NotifyError(@"Could not find credentials. Is CRC runnning?");
            }
        }

        async private void CopyOCLoginForDeveloperMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.CopyOCLoginForDeveloper).NoAwait();

            try
            {
                var consoleResult = await Task.Run(Tasks.LoginForDeveloper);
                Clipboard.SetText(string.Format("oc.exe login -u developer -p developer {0}",
                    consoleResult.ClusterConfig.ClusterAPI));
            }
            catch
            {
                TrayIcon.NotifyError(@"Could not find credentials. Is CRC running?");
            }
        }

        async private void OpenWebConsoleMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.ClickOpenConsole).NoAwait();

            try
            {
                var consoleResult = await Task.Run(Tasks.WebConsole);
                Process.Start(consoleResult.ClusterConfig.WebConsoleURL);
            }
            catch
            {
                TrayIcon.NotifyError(@"Could not open web console. Is CRC running?");
            }
        }

        async private void DeleteMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.ClickDelete).NoAwait();

            TrayIcon.NotifyInfo(@"Deleting cluster");

            await TaskHelpers.TryTaskAndNotify(Tasks.Delete,
                "Cluster deleted",
                "Could not delete the cluster",
                String.Empty);
        }

        async private void StopMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.ClickStop).NoAwait();

            TrayIcon.NotifyInfo(@"Stopping cluster");

            await TaskHelpers.TryTaskAndNotify(Tasks.Stop,
                "Cluster stopped",
                "Cluster could not be stopped",
                String.Empty);
        }

        async private void StartMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.ClickStart).NoAwait();

            // Check using get-config if pullSecret is configured
            bool pullsecretExists = false;
            try
            {
                pullsecretExists = await TaskHelpers.TryTaskWithRetry(Tasks.GetPullSecret);
            }
            catch (RetryableTaskFailedException ex)
            {
                TrayIcon.NotifyError($"Failed to start cluster as unable to fetch stored pull secret. {ex.Message}");
                return;
            }
            if (!pullsecretExists)
            {
                var pullSecretForm = new PullSecretForm();
                pullSecretForm.ShowDialog();
                var pullSecretContent = pullSecretForm.PullSecret;
                if (pullSecretContent == String.Empty)
                {
                    TrayIcon.NotifyWarn(@"No Pull Secret was provided. Cannot start cluster without pull secret.");
                    return;
                }

                TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.EnterPullSecret).NoAwait();

                // Store pullsecret; returns false is not able to
                var stored = await TaskHelpers.TryTask(Tasks.SetPullSecret, pullSecretContent);
                if (!stored)
                {
                    TrayIcon.NotifyError(@"Pull-secret not stored. Please check if valid format is used.");
                    return;
                }
            }

            TrayIcon.NotifyInfo(@"Starting Cluster");

            var startResult = await TaskHelpers.TryTaskAndNotify(Tasks.Start,
                String.Empty,
                "Cluster did not start",
                "Cluster still starting. Please check detailed status.");

            if (startResult != null && startResult.KubeletStarted)
                TrayIcon.NotifyInfo(@"CodeReady Containers Cluster has started");
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.Quit).NoAwait();

            QuitApp();
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.OpenAbout).NoAwait();

            if (about == null)
                about = new AboutForm();

            if (!about.Visible)
                about.Show();

            about.Focus();
        }

        private void ShowDetailedStatusForm(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.OpenStatus).NoAwait();

            if (statusForm == null)
                statusForm = new StatusForm();

            if (!statusForm.Visible)
                statusForm.Show();

            statusForm.Focus();
        }

        private void UpdateReceived(StatusResult statusResult)
        {
            SetStatusText(statusResult.CrcStatus);

            // TODO: enable based on status
            //startMenu.Enabled = false;
        }

        private void StopReceived(StopResult result)
        {
            SetStatusText(InitialState);
        }

        private void DeleteReceived(DeleteResult result)
        {
            SetStatusText(InitialState);
        }

        private void SetStatusText(string state)
        {
            status.Text = state;
            status.AccessibleName = state;
        }

        private void QuitApp()
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Environment.Exit(-1);
        }
    }
}

