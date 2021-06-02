using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using CRCTray.Communication;
using CRCTray.Helpers;

namespace CRCTray
{
    internal class CRCTray : ApplicationContext
    {
        private TrayIcon trayIcon;

        // MenuStrip Items
        private ToolStripItem status;
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
            trayIcon = new TrayIcon();
            
            StartDaemon();
            
            // Keep polling status and updating the statusMenuItem
            var statusPollingTimer = new System.Timers.Timer(pollInterval);
            statusPollingTimer.Enabled = true;
            statusPollingTimer.Elapsed += pollStatusTimerEventHandler;

            TaskHandlers.StatusChanged += UpdateReceived;
            TaskHandlers.StopReceived += StopReceived;
            TaskHandlers.DeleteReceived += DeleteReceived;

            SetContextMenu();
        }

        private void StartDaemon()
        {
            Task.Run(() => DaemonLauncher.Start(QuitApp));
        }

        private static void pollStatusTimerEventHandler(object source, System.Timers.ElapsedEventArgs e)
        {
            Task.Run(TaskHandlers.Status);
        }

        // populate the context menu for tray icon
        private void SetContextMenu()
        {
            ContextMenuStrip cm = new ContextMenuStrip();

            // Status Menu
            status = cm.Items.Add(InitialState); //TODO: actually "Unknown"
            status.Enabled = false;

            cm.Items.Add(new ToolStripSeparator());
            // Detailed status menu
            detailedStatusMenu = cm.Items.Add(@"Status and Logs");
            detailedStatusMenu.Click += ShowDetailedStatusForm;
            cm.Items.Add(new ToolStripSeparator());

            // Start Menu
            startMenu = cm.Items.Add(@"Start");
            startMenu.Click += StartMenu_Click;

            // Stop Menu
            stopMenu = cm.Items.Add(@"Stop");
            stopMenu.Click += StopMenu_Click;

            // Delete Menu
            deleteMenu = cm.Items.Add(@"Delete");
            deleteMenu.Click += DeleteMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // Open web console menu
            openWebConsoleMenu = cm.Items.Add(@"Launch Web Console");
            openWebConsoleMenu.Click += OpenWebConsoleMenu_Click;

            // Copy oc login command
            copyOCLoginCommand = cm.Items.Add(@"Copy OC Login Command");

            // Copy oc login command: developer
            copyOCLoginForDeveloperMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Developer");
            copyOCLoginForDeveloperMenu.Click += CopyOCLoginForDeveloperMenu_Click;
            // Copy oc login command: kubeadmin
            copyOCLoginForKubeadminMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Kubeadmin");
            copyOCLoginForKubeadminMenu.Click += CopyOCLoginForKubeadminMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // Settings menu
            settingsMenu = cm.Items.Add(@"Settings");
            settingsMenu.Click += SettingsMenu_Click;

            cm.Items.Add(new ToolStripSeparator());
            // About menu
            aboutMenu = cm.Items.Add(@"About");
            aboutMenu.Click += ShowAboutForm;

            // Exit menu
            exitMenu = cm.Items.Add(@"Exit");
            exitMenu.Click += ExitMenu_Click;

            // set context menu on trayicon
            trayIcon.ContextMenuStrip = cm;

            // enable items
            aboutMenu.Enabled = true;
            detailedStatusMenu.Enabled = true;
        }

        private void SettingsMenu_Click(object sender, EventArgs e)
        {
            if (settingsWindow == null)
                settingsWindow = new CrcSettingsForm();
            
            if (!settingsWindow.Visible)
                settingsWindow.Show();

            settingsWindow.Focus();
        }

        async private void CopyOCLoginForKubeadminMenu_Click(object sender, EventArgs e)
        {
            var consoleResult = await Task.Run(TaskHandlers.LoginForKubeadmin);

            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    Clipboard.SetText(string.Format("oc.exe login -u kubeadmin -p {0} {1}", consoleResult.ClusterConfig.KubeAdminPass, consoleResult.ClusterConfig.ClusterAPI));
                else
                    TrayIcon.NotifyError(@"Could not find credentials, is CRC runnning?");
            }
        }

        async private void CopyOCLoginForDeveloperMenu_Click(object sender, EventArgs e)
        {
            var consoleResult = await Task.Run(TaskHandlers.LoginForDeveloper);

            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    Clipboard.SetText(string.Format("oc.exe login -u developer -p developer {0}", consoleResult.ClusterConfig.ClusterAPI));
                else
                    TrayIcon.NotifyError(@"Could not find credentials, is CRC running?");
            }           
        }

        async private void OpenWebConsoleMenu_Click(object sender, EventArgs e)
        {
            var consoleResult = await Task.Run(TaskHandlers.WebConsole);

            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    Process.Start(consoleResult.ClusterConfig.WebConsoleURL);
                else
                    TrayIcon.NotifyError(@"Could not open web console, is CRC running?");
            }
        }

        async private void DeleteMenu_Click(object sender, EventArgs e)
        {
            TrayIcon.NotifyInfo(@"Deleting cluster");
            var deleteResult = await Task.Run(TaskHandlers.Delete);

            if (deleteResult != null)
            {
                if (deleteResult.Success)
                    TrayIcon.NotifyInfo(@"Cluster deleted");
                else
                    TrayIcon.NotifyError(@"Could not delete the cluster. Please check detailed status");
            }
            else
            {
                TrayIcon.NotifyError(@"Could not delete the cluster. Please check detailed status");
            }
        }

        async private void StopMenu_Click(object sender, EventArgs e)
        {
            TrayIcon.NotifyInfo(@"Stopping cluster");
            var stopResult = await Task.Run(TaskHandlers.Stop);

            if (stopResult != null)
            {
                if (stopResult.Success)
                    TrayIcon.NotifyInfo(@"Cluster Stopped");
                else
                    TrayIcon.NotifyError(@"Cluster could not be stopped. Please check detailed status");
            }
            else
            {
                TrayIcon.NotifyError(@"Cluster could not be stopped. Please check detailed status");
            }         
        }

        async private void StartMenu_Click(object sender, EventArgs e)
        {
            // Check using get-config if pullSecret is configured
            var configs = await Task.Run(TaskHandlers.ConfigView);
            if (configs.Configs.PullSecretFile == String.Empty)
            {
                var pullSecretForm = new PullSecretPickerForm();
                var pullSecretPath = pullSecretForm.ShowFilePicker();
                if (pullSecretPath == String.Empty)
                {
                    TrayIcon.NotifyWarn(@"No Pull Secret was provided, Cannot start cluster without pull secret.");
                    return;
                }
                Dictionary<String, dynamic> pullSecretConfig = new Dictionary<String, dynamic>
                {
                    ["pull-secret-file"] = pullSecretPath
                };
                await Task.Run(() => TaskHandlers.SetConfig(pullSecretConfig));
            }

            TrayIcon.NotifyInfo(@"Starting Cluster");
            var startResult = await Task.Run(TaskHandlers.Start);
            if (startResult == null)
            {
                return;
            }

            if (startResult.KubeletStarted)
                TrayIcon.NotifyInfo(@"CodeReady Containers Cluster has started");
            else
                TrayIcon.NotifyWarn(@"Cluster did not start. Please check detailed status");
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            QuitApp();
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            if (about == null)
                about = new AboutForm();

            if (!about.Visible)
                about.Show();

            about.Focus();
        }

        private void ShowDetailedStatusForm(object sender, EventArgs e)
        {
            if (statusForm == null)
                statusForm = new StatusForm();

            if (!statusForm.Visible)
                statusForm.Show();

            statusForm.Focus();
        }

        private void UpdateReceived(StatusResult statusResult)
        {
            status.Text = statusResult.CrcStatus;

            // TODO: enable based on status
            //startMenu.Enabled = false;
        }

        private void StopReceived(StopResult result)
        {
            status.Text = InitialState;
        }

        private void DeleteReceived(DeleteResult result)
        {
            status.Text = InitialState;
        }

        private void QuitApp()
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Environment.Exit(-1);
        }
    }
}

