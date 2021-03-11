using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.Json;
using tray_windows.Daemon;

namespace tray_windows
{
    class Handlers
    {
        public static StartResult HandleStart() 
        {
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.Start();
                return JsonSerializer.Deserialize<StartResult>(result);
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
            var daemon = new DaemonCommander(); 

            try
            {
                var result = daemon.Stop();
                return JsonSerializer.Deserialize<StopResult>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static DeleteResult HandleDelete()
        {
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.Delete();
                return JsonSerializer.Deserialize<DeleteResult>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static StatusResult HandleStatus()
        {
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.GetStatus();
                return JsonSerializer.Deserialize<StatusResult>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static ConsoleResult HandleOpenWebConsole()
        {
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.GetWebconsoleURL();
                return JsonSerializer.Deserialize<ConsoleResult>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static ConfigResult GetConfig() 
        {
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.GetAllConfig();
                return JsonSerializer.Deserialize<ConfigResult>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return new ConfigResult();  // returning an empty result?
            }
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            var config = new ConfigSetCommand();
            var configArgs = new ConfigSetCommandArg();
            configArgs.properties = cfg;

            config.command = "setconfig";
            config.args = configArgs;
            
            var daemon = new DaemonCommander();
            try
            {
                var result = daemon.SetConfig(config);
                return JsonSerializer.Deserialize<SetUnsetConfig>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return new SetUnsetConfig();  // returning an empty result?   
            }
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            var config = new ConfigUnsetCommand();
            var configArgs = new ConfigUnsetCommandArg();
            configArgs.properties = cfg;

            config.command = "unsetconfig";
            config.args = configArgs;

            var daemon = new Daemon.DaemonCommander();
            try
            {
                var result = daemon.UnsetConfig(config);
                return JsonSerializer.Deserialize<SetUnsetConfig>(result);
            }
            catch (SocketException ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return new SetUnsetConfig();  // returning an empty result?
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