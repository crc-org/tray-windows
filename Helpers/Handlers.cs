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
            return getResultsOrShowMessage(DaemonCommander.Version);
        }


        public static StartResult Start()
        {
            return getResultsOrShowMessage(DaemonCommander.Start);
        }

        public static StopResult Stop()
        {
            return getResultsOrShowMessage(DaemonCommander.Stop);
        }

        public static DeleteResult Delete()
        {
            return getResultsOrShowMessage(DaemonCommander.Delete);
        }

        public static StatusResult Status()
        {
            return getResultsOrShowMessage(DaemonCommander.Status);
        }

        public static ConsoleResult WebConsole()
        {
            return getResultsOrShowMessage(DaemonCommander.ConsoleUrl);
        }

        public static ConfigResult ConfigView()
        {
            return getResultsOrShowMessage(DaemonCommander.ConfigView);
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigSetCommand(cfg);
            return getResultsOrShowMessage(DaemonCommander.SetConfig, config);
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigUnsetCommand(cfg);
            return getResultsOrShowMessage(DaemonCommander.UnsetConfig, config);
        }

        public static ConsoleResult LoginForDeveloper()
        {
            return WebConsole();
        }

        public static ConsoleResult LoginForKubeadmin()
        {
            return WebConsole();
        }

        public static Logs GetDaemonLogs()
        {
            return getResultsOrShowMessage(DaemonCommander.GetLogs);
        }
    }
}