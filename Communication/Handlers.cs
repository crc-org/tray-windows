using System;
using System.Collections.Generic;
using CRCTray.Helpers;

namespace CRCTray.Communication
{
    class Handlers
    {
        public static StartResult HandleStart() 
        {
            try
            {
                return DaemonCommander.Start();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static StopResult HandleStop()
        {
            try
            {
                return DaemonCommander.Stop();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static DeleteResult HandleDelete()
        {
            try
            {
                return DaemonCommander.Delete();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static StatusResult HandleStatus()
        {
            try
            {
                return DaemonCommander.GetStatus();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static ConsoleResult HandleOpenWebConsole()
        {
            try
            {
                return DaemonCommander.GetWebconsoleURL();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static ConfigResult GetConfig() 
        {
            try
            {
                return DaemonCommander.GetAllConfig();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return new ConfigResult();  // returning an empty result?
            }
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigSetCommand(cfg);
            try
            {
                return DaemonCommander.SetConfig(config);
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return new SetUnsetConfig();  // returning an empty result?   
            }
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigUnsetCommand(cfg);
            try
            {
                return DaemonCommander.UnsetConfig(config);
            }
            catch (Exception ex)
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