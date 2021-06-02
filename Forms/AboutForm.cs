using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CRCTray.Communication;
using CRCTray.Helpers;
using System.Diagnostics;

namespace CRCTray
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

        private async void GetVersion(object sender, EventArgs e)
        {
            version = await Task.Run(TaskHandlers.Version);
            if (version.Success) {
                CrcVersionLabel.Text = String.Format("{0}+{1}", version.CrcVersion, version.CommitSha);
                OcpVersion.Text = version.OpenshiftVersion;
            }
            else
            {
                TrayIcon.NotifyWarn("Unable to fetch version information from daemon");
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

            Process.Start(docsUrl);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/code-ready/tray-windows");
        }
    }
}
