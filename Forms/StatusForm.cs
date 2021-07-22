using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CRCTray.Helpers;
using CRCTray.Communication;

namespace CRCTray
{
    public partial class StatusForm : Form
    {
        delegate void UpdateReceivedCallback(StatusResult status);
        delegate void StopReceivedCallback(StopResult status);
        delegate void DeleteReceivedCallback(DeleteResult status);
        Timer UpdateStatusTimer;

        private readonly string InitialState = @"Stopped";

        public StatusForm()
        {
            InitializeComponent();

            Tasks.StatusReceived += UpdateReceived;
            Tasks.StopReceived += StopReceived;
            Tasks.DeleteReceived += DeleteReceived;
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            // deal with async behaviour
            ResetStatusFields();

            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"Status and Logs";

            this.FormClosing += StatusForm_Closing;
            this.Activated += StatusForm_Activated;

            UpdateStatusTimer = new Timer();
            UpdateStatusTimer.Interval = 3000; // 3 seconds
            UpdateStatusTimer.Enabled = true;
            UpdateStatusTimer.Tick += Timer_Tick;

            // Initial states
            GetStatus();
            GetLogs();
        }

        private void ResetStatusFields()
        {
            const string _3dot = "...";
            CrcStatus.Text = InitialState;
            OpenShiftStatus.Text = _3dot;
            DiskUsage.Text = _3dot;
            CacheUsage.Text = _3dot;
            CacheFolder.Text = _3dot;
        }

        private void StatusForm_Activated(object sender, EventArgs e)
        {
            UpdateStatusTimer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Run as task to make sure it doesn't block this window
            GetStatus();
            GetLogs();
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            UpdateStatusTimer.Enabled = false;
            e.Cancel = true;
        }


        private void DeleteReceived(DeleteResult result)
        {
            if (CrcStatus.InvokeRequired)
            {
                DeleteReceivedCallback c = DeleteReceived;
                Invoke(c, result);
            }
            else
            {
                ResetStatusFields();
            }
        }

        private void StopReceived(StopResult result)
        {
            if (CrcStatus.InvokeRequired)
            {
                StopReceivedCallback c = StopReceived;
                Invoke(c, result);
            }
            else
            {
                ResetStatusFields();
            }
        }

        private void UpdateReceived(StatusResult status)
        {
            if (status != null)
            {
                if (CrcStatus.InvokeRequired)
                {
                    UpdateReceivedCallback c = UpdateReceived;
                    Invoke(c, status);
                }
                else
                {
                    if (status.CrcStatus != "")
                        CrcStatus.Text = status.CrcStatus;
                    else
                        CrcStatus.Text = InitialState;

                    if (status.OpenshiftStatus != "") 
                        OpenShiftStatus.Text = StatusText(status);

                    var cacheFolderPath = string.Format("{0}\\.crc\\cache", 
                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

                    DiskUsage.Text = string.Format("{0} of {1} (Inside the CRC VM)",
                        FileSize.HumanReadable(status.DiskUse), FileSize.HumanReadable(status.DiskSize));
                    CacheUsage.Text = FileSize.HumanReadable(GetFolderSize.SizeInBytes(cacheFolderPath));
                    CacheFolder.Text = cacheFolderPath;
                }
            }
        }
        
        private static string StatusText(StatusResult status)
        {
            var ret = "";
            if (!string.IsNullOrEmpty(status.OpenshiftStatus))
                ret += status.OpenshiftStatus;
            if (!string.IsNullOrEmpty(status.OpenshiftVersion))
                ret += string.Format(" (v{0})", status.OpenshiftVersion);
            return ret;
        }


        private void GetStatus()
        {
            try
            {
                Task.Run(Tasks.Status);
            }
            catch
            {
                // Status failed, but ignoring
            }
        }

        private async void GetLogs()
        {
            try
            {
                var logs = await Task.Run(Tasks.GetDaemonLogs);
                if (logs != null)
                {
                    var messages = string.Join("\r\n", logs.Messages);

                    if (logsTextBox.Text == messages)
                        return;

                    logsTextBox.Text = messages;
                    logsTextBox.SelectionStart = logsTextBox.Text.Length;
                    logsTextBox.ScrollToCaret();
                }
            }
            catch
            {
                // Logs failed, but ignoring
            }
        }
    }

    public static class FileSize
    {
        // Load all suffixes in an array  
        static readonly string[] suffixes =
        { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string HumanReadable(long bytes)
        {
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }

    }

    public static class GetFolderSize
    {
        public static long SizeInBytes(string path)
        {
            long size = 0;

            var dirInfo = new DirectoryInfo(path);
            try
            {
                foreach (FileInfo fi in dirInfo.GetFiles("*", SearchOption.AllDirectories))
                {
                    size += fi.Length;
                }
            }
            catch (Exception e)
            {
                TrayIcon.NotifyError(string.Format("Unexpected Error, did you run 'crc setup'? Error: {0}", e.Message));
            }
            return size;
        }
    }
}
