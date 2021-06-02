using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRCTray.Helpers;

namespace CRCTray
{
    public partial class PullSecretPickerForm : Form
    {
        string pullSecretPath = "";
        public PullSecretPickerForm()
        {
            InitializeComponent();
        }

        private void PullSecretPicker_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            browseFile.ShowDialog();
            if (browseFile.FileName != "")
            { 
                pullSecretPath = browseFile.FileName;
                pullSecretPathTextField.Text = pullSecretPath;
            }

            Console.WriteLine("Selected file: {0}", pullSecretPath);
        }

        public String ShowFilePicker()
        {
            base.ShowDialog();
            return pullSecretPath;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const String url = "https://cloud.redhat.com/openshift/create/local";
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                TrayIcon.NotifyWarn(string.Format("Cannot open URL in default browser {0}", ex.ToString()));
            }
        }
    }
}
