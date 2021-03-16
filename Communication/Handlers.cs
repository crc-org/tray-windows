using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.Json;
using CRCTray.Helpers;

namespace CRCTray.Communication
{
    class Handlers
    {
        public static StartResult HandleStart() 
        {
            try
            {
                var result = DaemonCommander.Start();
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
            try
            {
                var result = DaemonCommander.Stop();
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
            try
            {
                var result = DaemonCommander.Delete();
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
            try
            {
                var result = DaemonCommander.GetStatus();
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
            try
            {
                var result = DaemonCommander.GetWebconsoleURL();
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
            try
            {
                var result = DaemonCommander.GetAllConfig();
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
            var config = new ConfigSetCommand(cfg);
            try
            {
                var result = DaemonCommander.SetConfig(config);
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
            var config = new ConfigUnsetCommand(cfg);
            try
            {
                var result = DaemonCommander.UnsetConfig(config);
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