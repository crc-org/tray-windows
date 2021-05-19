using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using CRCTray.Communication;
using CRCTray.Helpers;

namespace CRCTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayContext());
        }
    }

    internal class TrayContext : ApplicationContext
    {
        //tray Icon
        private NotifyIcon notifyIcon;

        // MenuStrip Items
        private static ToolStripItem status;
        private static ToolStripItem detailedStatusMenu;
        private static ToolStripItem startMenu;
        private static ToolStripItem stopMenu;
        private static ToolStripItem deleteMenu;
        private static ToolStripItem openWebConsoleMenu;
        private static ToolStripItem copyOCLoginCommand;
        private static ToolStripItem copyOCLoginForDeveloperMenu;
        private static ToolStripItem copyOCLoginForKubeadminMenu;
        private static ToolStripItem aboutMenu;
        private static ToolStripItem exitMenu;
        private static ToolStripItem settingsMenu;

        // Forms
        private Form settingsWindow;
        private Form about;
        private Form statusForm;

        private Double pollInterval = 30000; // 30 seconds poll interval

        // Initialize tray
        public TrayContext()
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            notifyIcon = new NotifyIcon
            {
                Icon = Icon.FromHandle(bm.GetHicon()),
                Visible = true
            };
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
            // start daemon
            Task.Run(StartDaemon);
            System.Threading.Thread.Sleep(6000); // wait 6sec for the daemon to start
            PollStatus();
            // Keep polling status and updating the statusMenuItem
            var statusPollingTimer = new System.Timers.Timer(pollInterval);
            statusPollingTimer.Enabled = true;
            statusPollingTimer.Elapsed += pollStatusTimerEventHandler;

            SetContextMenu();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(notifyIcon, null);
        }

        // event handlers and methods
        async static void PollStatus()
        {
            var status = await Task.Run(() => TaskHandlers.Status());
            if (status != null)
                    UpdateClusterStatusMenu(status);
        }

        private static void pollStatusTimerEventHandler(object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed event raise, polling status");
            PollStatus();
        }

        // populate the context menu for tray icon
        private void SetContextMenu()
        {
            ContextMenuStrip cm = new ContextMenuStrip();

            // Status Menu
            status = cm.Items.Add(@"Unknown");
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


            this.notifyIcon.ContextMenuStrip = cm;
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
            var consoleResult = await Task.Run(() => TaskHandlers.LoginForKubeadmin());
            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    Clipboard.SetText(string.Format("oc.exe login -u kubeadmin -p {0} {1}", consoleResult.ClusterConfig.KubeAdminPass, consoleResult.ClusterConfig.ClusterAPI));
                else
                    ShowNotification(@"Could not find credentials, is CRC runnning?", ToolTipIcon.Error);
            }
        }

        async private void CopyOCLoginForDeveloperMenu_Click(object sender, EventArgs e)
        {
            var consoleResult = await Task.Run(() => TaskHandlers.LoginForDeveloper());
            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    Clipboard.SetText(string.Format("oc.exe login -u developer -p developer {0}", consoleResult.ClusterConfig.ClusterAPI));
                else
                    ShowNotification(@"Could not find credentials, is CRC running?", ToolTipIcon.Error);
            }           
        }

        async private void OpenWebConsoleMenu_Click(object sender, EventArgs e)
        {
            var consoleResult = await Task.Run(() => TaskHandlers.WebConsole());
            if (consoleResult != null)
            {
                if (consoleResult.Success)
                    System.Diagnostics.Process.Start(consoleResult.ClusterConfig.WebConsoleURL);
                else
                    ShowNotification(@"Could not open web console, is CRC running?", ToolTipIcon.Error);
            }            
        }

        async private void DeleteMenu_Click(object sender, EventArgs e)
        {
            ShowNotification(@"Deleting Cluster", ToolTipIcon.Warning);
            var deleteResult = await Task.Run(() => TaskHandlers.Delete());
            if (deleteResult != null)
            {
                if (deleteResult.Success)
                    DisplayMessageBox.Info(@"CodeReady Containers Cluster has been deleted", @"Cluster Deleted");
                else
                    DisplayMessageBox.Warn(@"Could not delete the cluster");
            }            
        }

        async private void StopMenu_Click(object sender, EventArgs e)
        {
            ShowNotification(@"Stopping Cluster", ToolTipIcon.Info);
            var stopResult = await Task.Run(() => TaskHandlers.Stop());
            if (stopResult != null)
            {
                if (stopResult.Success)
                    DisplayMessageBox.Info(@"CodeReady Containers Cluster has stopped", @"Cluster Stopped");
                else
                    DisplayMessageBox.Warn(@"Cluster did not stop. Please check detailed status");
            }            
        }

        async private void StartMenu_Click(object sender, EventArgs e)
        {
            // Check using get-config if pullSecret is configured
            var configs = TaskHandlers.ConfigView();
            if (configs.Configs.PullSecretFile == "")
            {
                var pullSecretForm = new PullSecretPickerForm();
                var pullSecretPath = pullSecretForm.ShowFilePicker();
                if (pullSecretPath == "")
                {
                    DisplayMessageBox.Warn("No Pull Secret was provided, Cannot start cluster without pull secret.");
                    return;
                }
                Dictionary<String, dynamic> pullSecretConfig = new Dictionary<String, dynamic>
                {
                    ["pull-secret-file"] = pullSecretPath
                };
                TaskHandlers.SetConfig(pullSecretConfig);
            }

            ShowNotification(@"Starting Cluster", ToolTipIcon.Info);
            var startResult = await Task.Run(() => TaskHandlers.Start());
            if (startResult == null)
            {
                return;
            }
            if (startResult.KubeletStarted)
                DisplayMessageBox.Info(@"CodeReady Containers Cluster has started", @"Cluster Started");
            else
                DisplayMessageBox.Warn(@"Cluster did not start. Please check detailed status");
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
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

        private static void UpdateClusterStatusMenu(StatusResult statusResult)
        {
            if (!string.IsNullOrEmpty(statusResult.CrcStatus))
                status.Text = statusResult.CrcStatus;
            else
                status.Text = @"Stopped";

            EnableMenuItems();
        }

        private static void EnableMenuItems()
        {
            startMenu.Enabled = true;
            deleteMenu.Enabled = true;
            stopMenu.Enabled = true;
            openWebConsoleMenu.Enabled = true;
            copyOCLoginCommand.Enabled = true;
            copyOCLoginForDeveloperMenu.Enabled = true;
            copyOCLoginForKubeadminMenu.Enabled = true;
            aboutMenu.Enabled = true;
            detailedStatusMenu.Enabled = true;
        }

        public void ShowNotification(string msg, ToolTipIcon toolTipIcon)
        {
            notifyIcon.BalloonTipIcon = toolTipIcon;
            notifyIcon.BalloonTipText = msg;
            notifyIcon.ShowBalloonTip(10);
        }
        private void StartDaemon()
        {
            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.FileName = string.Format("{0}\\{1}\\crc.exe",
                Environment.GetEnvironmentVariable("ProgramW6432"), @"CodeReady Containers");
#if DEBUG
            process.StartInfo.FileName = string.Format("{0}\\bin\\crc.exe", Environment.GetEnvironmentVariable("GOPATH"));
#endif
            process.StartInfo.Arguments = @"daemon --watchdog";
            process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(process.StartInfo.FileName);
            try
            {
                process.Start();
                System.IO.StreamWriter daemonStdinWriter = process.StandardInput;
            }
            catch (Exception e)
            {
                DisplayMessageBox.Error(string.Format("Cannot start the daemon, Check the logs and restart the application, Error: {0}", e.Message));
            }
            process.WaitForExit();
            if (process.ExitCode == 2)
            {
                DisplayMessageBox.Error("Setup incomplete, Open a terminal, run 'crc setup', and start again this application.");
            }
            else
            {
                DisplayMessageBox.Error("Daemon crashed, check the logs and restart the application");
            }
        }
    }
}

