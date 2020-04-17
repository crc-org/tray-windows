using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace tray_windows
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"About";
            FormClosing += AboutForm_FormClosing;
            TrayVersion.Text = Application.ProductVersion;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Shown += GetVersion;
        }

        private void GetVersion(object sender, EventArgs e)
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetVersion();
                VersionResult version = JsonConvert.DeserializeObject<VersionResult>(r);
                if (version.Success) {
                    CrcVersionLabel.Text = String.Format("{0}+{1}", version.CrcVersion, version.CommitSha);
                    OcpVersion.Text = version.OpenshiftVersion;
                }
                else
                {
                    DisplayMessageBox.Warn("Unable to fetch version information from daemon", "Version");
                }
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                this.Hide();
                DisplayMessageBox.Warn(ex.Message, "Error connecting to daemon");
            }
        }
        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void TrayGHRepoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/code-ready/tray-windows");
        }
    }
}
