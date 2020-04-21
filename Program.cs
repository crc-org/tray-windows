using System;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;

namespace tray_windows
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
        private ToolStripItem copyOCLoginCommandForKubeadminMenu;
        private ToolStripItem aboutMenu;
        private ToolStripItem exitMenu;

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

            SetConextMenu();
        }

        // event handlers and methods
        private void NotifyIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(notifyIcon, null);
                UpdateClusterStatusMenu();
            }
        }

        // populate the context menu for tray icon
        private void SetConextMenu()
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

            // Stop Menu
            stopMenu = cm.Items.Add(@"Stop");

            // Delete Menu
            deleteMenu = cm.Items.Add(@"Delete");

            cm.Items.Add(new ToolStripSeparator());
            // Open web console menu
            openWebConsoleMenu = cm.Items.Add(@"Launch Web Console");

            // Copy oc login command
            copyOCLoginCommand = cm.Items.Add(@"Copy OC Login Command");

            // Copy oc login command: developer
            copyOCLoginForDeveloperMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Developer");
            // Copy oc login command: kubeadmin
            copyOCLoginCommandForKubeadminMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Kubeadmin");

            cm.Items.Add(new ToolStripSeparator());
            // About menu
            aboutMenu = cm.Items.Add(@"About");
            aboutMenu.Click += ShowAboutForm;

            // Exit menu
            exitMenu = cm.Items.Add(@"Exit");
            exitMenu.Click += ExitMenu_Click;


            this.notifyIcon.ContextMenuStrip = cm;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            if (!about.Visible)
                about.Show();
        }

        private void ShowDetailedStatusForm(object sender, EventArgs e)
        {
            Form status = new StatusForm();
            if (!status.Visible)
                status.Show();
        }

        private void UpdateClusterStatusMenu()
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetStatus();
                StatusResult status = JsonConvert.DeserializeObject<StatusResult>(r);
                if (!string.IsNullOrEmpty(status.CrcStatus))
                    this.status.Text = status.CrcStatus;
                else
                    this.status.Text = @"Unknown";
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                notifyIcon.ContextMenuStrip.Hide();
                DisplayMessageBox.Error(ex.Message, "Error connecting to daemon");
            }
        }
    }
}

