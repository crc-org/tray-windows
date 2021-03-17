using System;
using System.Collections.Generic;
using CRCTray.Communication;

namespace CRCTray.Helpers
{
    static class TaskHandlers
    {
        private static T getResultsOrShowMessage<T>(Func<T> function)
        {
            try
            {
                return function();
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return default;
            }
        }
        private static T getResultsOrShowMessage<T, TArgs>(Func<TArgs, T> function, TArgs args)
        {
            try
            {
                return function(args);
            }
            catch (Exception ex)
            {
                DisplayMessageBox.Error(ex.Message);
                return default;
            }
        }

        public static VersionResult Version()
        {
            return getResultsOrShowMessage<VersionResult>(DaemonCommander.GetVersion);
        }


        public static StartResult Start() 
        {
            return getResultsOrShowMessage<StartResult>(DaemonCommander.Start);
        }

        public static StopResult Stop()
        {
            return getResultsOrShowMessage<StopResult>(DaemonCommander.Stop);
        }

        public static DeleteResult Delete()
        {
            return getResultsOrShowMessage<DeleteResult>(DaemonCommander.Delete);
        }

        public static StatusResult Status()
        {
            return getResultsOrShowMessage<StatusResult>(DaemonCommander.GetStatus);
        }

        public static ConsoleResult WebConsole()
        {
            return getResultsOrShowMessage<ConsoleResult>(DaemonCommander.GetWebconsoleURL);
        }

        public static ConfigResult GetConfig() 
        {
            return getResultsOrShowMessage<ConfigResult>(DaemonCommander.GetAllConfig);
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigSetCommand(cfg);
            return getResultsOrShowMessage<SetUnsetConfig, ConfigSetCommand>(DaemonCommander.SetConfig, config);
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigUnsetCommand(cfg);
            return getResultsOrShowMessage<SetUnsetConfig, ConfigUnsetCommand>(DaemonCommander.UnsetConfig, config);
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