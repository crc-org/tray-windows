using Newtonsoft.Json;
using System.Net.Sockets;

namespace tray_windows
{
    class Handlers
    {
        public static StartResult HandleStart() 
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.Start();
                StartResult sr = JsonConvert.DeserializeObject<StartResult>(r);
                return sr;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static StopResult HandleStop()
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.Stop();
                StopResult sr = JsonConvert.DeserializeObject<StopResult>(r);
                return sr;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static DeleteResult HandleDelete()
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.Delete();
                DeleteResult dr = JsonConvert.DeserializeObject<DeleteResult>(r);
                return dr;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static ConsoleResult HandleOpenWebConsole()
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetWebconsoleURL();
                ConsoleResult cr = JsonConvert.DeserializeObject<ConsoleResult>(r);
                return cr;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }
        
        public static ConsoleResult HandleOCLogingForDeveloper()
        {
            return HandleOpenWebConsole();
        }

        public static ConsoleResult HandleOCLoginForKubeadmin()
        {
            return HandleOpenWebConsole();
        }
    }
}