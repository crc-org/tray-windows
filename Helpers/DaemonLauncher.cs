using System;
using System.Diagnostics;
using System.IO;

namespace CRCTray.Helpers
{
    class DaemonLauncher
    {
        internal static bool Start(Action quitFunc)
        {
            // TODO: Action to be replaced with an event 'Stopped'

            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            var currentExecutableLocation = typeof(Program).Assembly.Location;
            var crcPath = Path.Combine(Path.GetDirectoryName(currentExecutableLocation), "crc.exe");
            process.StartInfo.FileName = crcPath;

#if DEBUG
            process.StartInfo.FileName = Path.Combine(Environment.GetEnvironmentVariable("GOPATH"), "bin", "crc.exe");
#endif
            process.StartInfo.Arguments = @"daemon --watchdog";
            process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            try
            {
                process.Start();
                System.IO.StreamWriter daemonStdinWriter = process.StandardInput;
            }
            catch
            {
                TrayIcon.NotifyError(@"Cannot start the daemon, Check the logs and restart the application");
 
                quitFunc();
            }

            process.WaitForExit();
            if (process.ExitCode == 2)
            {
                TrayIcon.NotifyError(@"Setup incomplete, Open a terminal, run 'crc setup', and start again this application.");
            }
            else
            {
                TrayIcon.NotifyError(@"Daemon crashed, check the logs and restart the application");
            }

            quitFunc();

            // Return value to allow wrapping with TryTask
            return true;
        }
    }
}
