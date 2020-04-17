using System;
using System.Drawing;
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

            //VisibleChanged += GetStatus;
            Shown += GetStatus;
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
                //System.Diagnostics.EventLog.WriteEntry("crc-tray-windows", status.Error, System.Diagnostics.EventLogEntryType.Error);
                DiskUsage.Text = status.DiskUsage.ToString();
                CacheFolderStatus.Text = status.DiskSize.ToString();
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                this.Hide();
                DisplayMessageBox.Warn(ex.Message, "Error connecting to daemon");
            }
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
