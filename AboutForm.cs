using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Icon = Icon.FromHandle(bm.GetHicon());
            this.Text = @"About CodeReady Containers";
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void TrayGHRepoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/code-ready/tray-windows");
        }
    }
}
