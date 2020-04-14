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
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"Status";
            
            
            //FormClosing += StatusForm_Closing;
            //Activated += GetStatus;

            VisibleChanged += GetStatus;
            //Shown += GetStatus;
        }

        private void GetStatus(object sender, EventArgs e)
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetStatus();
                StatusResult status = JsonConvert.DeserializeObject<StatusResult>(r);
                CrcStatus.Text = status.CrcStatus;
                OpenShiftStatus.Text = status.OpenshiftStatus;
                //DiskUsage.Text = (string) status.DiskUsage;
                //CacheFolderStatus.Text = status.DiskSize;
            }
            catch(Exception ex)
            {
                this.Hide();
                MessageBox.Show(ex.Message);
            }
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
