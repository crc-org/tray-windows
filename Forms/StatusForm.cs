using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CRCTray.Communication;
using CRCTray.Helpers;

namespace CRCTray
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
            Text = @"Status and Logs";
            Console.WriteLine("For loaded");
            
            this.FormClosing += StatusForm_Closing;
            // Update logs
            GetStatus();
            UpdateLogs();

            var timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Updating logs");
            UpdateLogs();
            GetStatus();
        }

        async private void GetStatus()
        {
            var status = await Task.Run(() => TaskHandlers.Status());
            if (status != null)
            {
                var cacheFolderPath = string.Format("{0}\\.crc\\cache", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                Console.WriteLine(status);
                Console.WriteLine(status.OpenshiftStatus);
                if (status.Error != "")
                {
                    CrcStatus.Text = ErrorText(status);
                    OpenShiftStatus.Text = "Unknown";
                }
                else if (status.CrcStatus != "")
                {
                    CrcStatus.Text = status.CrcStatus;
                    OpenShiftStatus.Text = StatusText(status);
                }
                DiskUsage.Text = string.Format("{0} of {1} (Inside the CRC VM)", FileSize.HumanReadable(status.DiskUse), FileSize.HumanReadable(status.DiskSize));
                CacheUsage.Text = FileSize.HumanReadable(GetFolderSize.SizeInBytes(cacheFolderPath));
                CacheFolder.Text = cacheFolderPath;
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

        private static string ErrorText(StatusResult status)
        {
            if (status.Error.Length > 200)
            {
                return status.Error.Substring(0, Math.Min(200, status.Error.Length)) + " ...";                
            }
            return status.Error;
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void UpdateLogs()
        {
            var logs = TaskHandlers.GetDaemonLogs();
            var messages = string.Join("\r\n", logs.Messages);
            if (logsTextBox.Text == messages)
                return;
            logsTextBox.Text = messages;
            logsTextBox.SelectionStart = logsTextBox.Text.Length;
            logsTextBox.ScrollToCaret();
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
                DisplayMessageBox.Error(string.Format("Unexpected Error, did you run 'crc setup'? Error: {0}", e.Message));
            }
            return size;
        }
    }
}
