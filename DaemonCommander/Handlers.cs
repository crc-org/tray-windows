using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using tray_windows.Daemon;

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
            catch (JsonException ex)
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

        public static StatusResult HandleStatus()
        {
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetStatus();
                StatusResult sr = JsonConvert.DeserializeObject<StatusResult>(r);
                return sr;
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

        public static ConfigResult GetConfig() 
        {
            ConfigResult cr = new ConfigResult();
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.GetAllConfig();
                cr = JsonConvert.DeserializeObject<ConfigResult>(r);
                return cr;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return cr;
            }
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            var result = new SetUnsetConfig();
            var config = new ConfigSetCommand();
            var configArgs = new ConfigSetCommandArg();
            configArgs.properties = cfg;

            config.command = "setconfig";
            config.args = configArgs;
            
            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.SetConfig(config);
                result = JsonConvert.DeserializeObject<SetUnsetConfig>(r);
                return result;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return result;
            }
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            var result = new SetUnsetConfig();
            var config = new ConfigUnsetCommand();
            var configArgs = new ConfigUnsetCommandArg();
            configArgs.properties = cfg;

            config.command = "unsetconfig";
            config.args = configArgs;

            var d = new Daemon.DaemonCommander();
            try
            {
                var r = d.UnsetConfig(config);
                result = JsonConvert.DeserializeObject<SetUnsetConfig>(r);
                return result;
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return result;
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