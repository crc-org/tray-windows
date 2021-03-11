using System;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace tray_windows
{
    public partial class AboutForm : Form
    {
        private VersionResult version;
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
            var daemon = new Daemon.DaemonCommander();
            try
            {
                var result = daemon.GetVersion();
                version = JsonSerializer.Deserialize<VersionResult>(result);
                if (version.Success) {
                    CrcVersionLabel.Text = String.Format("{0}+{1}", version.CrcVersion, version.CommitSha);
                    OcpVersion.Text = version.OpenshiftVersion;
                }
                else
                {
                    DisplayMessageBox.Warn("Unable to fetch version information from daemon");
                }
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                this.Hide();
                DisplayMessageBox.Warn(ex.Message);
            }
        }
        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var crcVersionWithGitSha = version.CrcVersion.Split('+');                  
            var v = crcVersionWithGitSha[0].Substring(0, crcVersionWithGitSha[0].Length - 2);
            var docsUrl = string.Format("https://access.redhat.com/documentation/en-us/red_hat_codeready_containers/{0}/", v);
            System.Diagnostics.Process.Start(docsUrl);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/code-ready/tray-windows");
        }
    }
}
