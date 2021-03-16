using System;
using System.Collections.Generic;
using CRCTray.Communication;

namespace CRCTray.Helpers
{
    static class TaskHandlers
    {

        public static VersionResult Version()
        {
            try
            {
                return DaemonCommander.GetVersion();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return null;
            }
        }

        public static StartResult Start() 
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

        public static StopResult Stop()
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

        public static DeleteResult Delete()
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

        public static StatusResult Status()
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

        public static ConsoleResult WebConsole()
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
        
        public static ConsoleResult LoginForDeveloper()
        {
            return WebConsole();
        }

        public static ConsoleResult LoginForKubeadmin()
        {
            return WebConsole();
        }

    }
}