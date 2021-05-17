using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
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
            Text = @"Detailed Status";
            
            
            this.FormClosing += StatusForm_Closing;
            //Activated += GetStatus;

            //VisibleChanged += GetStatus;
            Shown += GetStatus;
        }

        async private void GetStatus(object sender, EventArgs e)
        {
            var status = await Task.Run(() => TaskHandlers.Status());
            if (status != null)
            {
                var cacheFolderPath = string.Format("{0}\\.crc\\cache", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

                CrcStatus.Text = status.CrcStatus;
                OpenShiftStatus.Text = status.OpenshiftStatus;
                DiskUsage.Text = string.Format("{0} of {1} (Inside the CRC VM)", FileSize.HumanReadable(status.DiskUse), FileSize.HumanReadable(status.DiskSize));
                CacheUsage.Text = FileSize.HumanReadable(GetFolderSize.SizeInBytes(cacheFolderPath));
                CacheFolder.Text = cacheFolderPath;
            }
        }

        private void StatusForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
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
