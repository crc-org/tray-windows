using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;

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

            //VisibleChanged += GetStatus;
            Shown += GetStatus;
        }

        async private void GetStatus(object sender, EventArgs e)
        {
            var status = await Task.Run(() => Handlers.HandleStatus());
            if (status != null)
            {
                CrcStatus.Text = status.CrcStatus;
                OpenShiftStatus.Text = status.OpenshiftStatus;
                DiskUsage.Text = status.DiskUsage.ToString();
                CacheFolderStatus.Text = status.DiskSize.ToString();
            }
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
