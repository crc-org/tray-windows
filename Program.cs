using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
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
        private ToolStripItem status;
        private ToolStripItem detailedStatusMenu;
        private ToolStripItem startMenu;
        private ToolStripItem stopMenu;
        private ToolStripItem deleteMenu;
        private ToolStripItem openWebConsoleMenu;
        private ToolStripItem copyOCLoginCommand;
        private ToolStripItem copyOCLoginForDeveloperMenu;
        private ToolStripItem copyOCLoginForKubeadminMenu;
        private ToolStripItem aboutMenu;
        private ToolStripItem exitMenu;
        private ToolStripItem settingsMenu;

        // Forms
        private Form settingsWindow = new CrcSettingsForm();
        private Form about = new AboutForm();
        private Form statusForm = new StatusForm();

        // Initialize tray
        public TrayContext()
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            notifyIcon = new NotifyIcon
            {
                Icon = Icon.FromHandle(bm.GetHicon()),
                Visible = true
            };
            notifyIcon.MouseClick += NotifyIcon_Click;

            SetContextMenu();
        }

        // event handlers and methods
        async private void NotifyIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(notifyIcon, null);
                var status = await Task.Run(() => TaskHandlers.Status());
                if (status != null)
                {
                    UpdateClusterStatusMenu(status);
                    SyncMenuItemStates(status);
                }
            }
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
            detailedStatusMenu = cm.Items.Add(@"Detailed Status");
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
            ShowNotification(@"Starting Cluster", ToolTipIcon.Info);
            var startResult = await Task.Run(() => TaskHandlers.Start());
            if (startResult != null)
            {
                if (startResult.KubeletStarted)
                    DisplayMessageBox.Info(@"CodeReady Containers Cluster has started", @"Cluster Started");
                else
                    DisplayMessageBox.Warn(@"Cluster did not start. Please check detailed status");
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            if (!about.Visible)
                about.Show();
            about.Focus();
        }

        private void ShowDetailedStatusForm(object sender, EventArgs e)
        {
            if (!statusForm.Visible)
                statusForm.Show();
            statusForm.Focus();
        }

        private void UpdateClusterStatusMenu(StatusResult status)
        {
            if (!string.IsNullOrEmpty(status.CrcStatus))
                this.status.Text = status.CrcStatus;
            else
                this.status.Text = @"Unknown";
        }

        private void SyncMenuItemStates(StatusResult status)
        {
            if (status.CrcStatus == @"Running")
            {
                startMenu.Enabled = false;
                deleteMenu.Enabled = true;
                stopMenu.Enabled = true;
                openWebConsoleMenu.Enabled = true;
                copyOCLoginCommand.Enabled = true;
                copyOCLoginForDeveloperMenu.Enabled = true;
                copyOCLoginForKubeadminMenu.Enabled = true;
            }
            else if (status.CrcStatus == @"Stopped")
            {
                startMenu.Enabled = true;
                deleteMenu.Enabled = true;
                stopMenu.Enabled = false;
                openWebConsoleMenu.Enabled = false;
                copyOCLoginCommand.Enabled = false;
                copyOCLoginForDeveloperMenu.Enabled = false;
                copyOCLoginForKubeadminMenu.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(status.Error) && status.Error.Contains("does not exist"))
            {
                startMenu.Enabled = true;
                deleteMenu.Enabled = false;
                stopMenu.Enabled = false;
                openWebConsoleMenu.Enabled = false;
                copyOCLoginCommand.Enabled = false;
                copyOCLoginForDeveloperMenu.Enabled = false;
                copyOCLoginForKubeadminMenu.Enabled = false;
            }
            else
            {
                startMenu.Enabled = true;
                stopMenu.Enabled = false;
                deleteMenu.Enabled = true;
                openWebConsoleMenu.Enabled = false;
                copyOCLoginCommand.Enabled = false;
                copyOCLoginForDeveloperMenu.Enabled = false;
                copyOCLoginForKubeadminMenu.Enabled = false;
            }
        }

        public void ShowNotification(string msg, ToolTipIcon toolTipIcon)
        {
            notifyIcon.BalloonTipIcon = toolTipIcon;
            notifyIcon.BalloonTipText = msg;
            notifyIcon.ShowBalloonTip(10);
        }
    }
}

