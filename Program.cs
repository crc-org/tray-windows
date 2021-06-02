using System;
using System.Windows.Forms;

namespace CRCTray
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Fix for blurry controls
            // http://crsouza.com/2015/04/13/how-to-fix-blurry-windows-forms-windows-in-high-dpi-settings/
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CRCTray());
        }

        // Fix for blurry controls taken from
        // http://crsouza.com/2015/04/13/how-to-fix-blurry-windows-forms-windows-in-high-dpi-settings/
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}