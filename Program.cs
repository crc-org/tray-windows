using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
        private NotifyIcon notifyIcon;
        private Form about = new AboutForm();
        private Form status = new StatusForm();
        public TrayContext()
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            notifyIcon = new NotifyIcon
            {
                Icon = Icon.FromHandle(bm.GetHicon()),
                Visible = true
            };
            
            SetConextMenu();
        }

        private void SetConextMenu()
        {
            ContextMenuStrip cm = new ContextMenuStrip();

            // Status Menu
            var status = cm.Items.Add(@"Unknown");
            status.Image = Resource.status_unknown;
            status.Enabled = false;

            cm.Items.Add(new ToolStripSeparator());
            // Detailed status menu
            var detailedStatusMenu = cm.Items.Add(@"Detailed Status");
            detailedStatusMenu.Click += ShowDetailedStatusForm;
            cm.Items.Add(new ToolStripSeparator());

            // Start Menu
            var startMenu = cm.Items.Add(@"Start");

            // Stop Menu
            var stopMenu = cm.Items.Add(@"Stop");

            // Delete Menu
            var deleteMenu = cm.Items.Add(@"Delete");

            cm.Items.Add(new ToolStripSeparator());
            // Open web console menu
            var openWebConsoleMenu = cm.Items.Add(@"Launch Web Console");

            // Copy oc login command
            var copyOCLoginCommand = cm.Items.Add(@"Copy OC Login Command");

            // Copy oc login command: developer
            var copyOCLoginForDeveloperMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Developer");
            // Copy oc login command: kubeadmin
            var copyOCLoginCommandForKubeadminMenu = (copyOCLoginCommand as ToolStripMenuItem).DropDownItems.Add(@"Kubeadmin");

            cm.Items.Add(new ToolStripSeparator());
            // About menu
            var aboutMenu = cm.Items.Add(@"About");
            aboutMenu.Click += ShowAboutForm;

            // Exit menu
            var exitMenu = cm.Items.Add(@"Exit");


            this.notifyIcon.ContextMenuStrip = cm;
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            if (!this.about.Visible)
            {
                this.about.Show();
            }
        }

        private void ShowDetailedStatusForm(object sender, EventArgs e)
        {
            if (!this.status.Visible)
            {
                this.status.Show();
            }
        }
    }
}

