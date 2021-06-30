using CRCTray.Communication;
using System;
using System.Collections.Generic;

namespace CRCTray.Helpers
{
    // Events for status command
    public delegate void StatusChangedHandler(StatusResult result);
    public delegate void StatusReceivedHandler(StatusResult result);

    // Events for commands
    public delegate void LogsReceivedHandler(LogsResult result);
    public delegate void StartReceivedHandler(StartResult result);
    public delegate void StopReceivedHandler(StopResult result);
    public delegate void DeleteReceivedHandler(DeleteResult result);

    static class TaskHandlers
    {
        private static string _previousStatus;
        private static readonly object _statusChangeLock = new object();

        public static event StatusChangedHandler StatusChanged;
        public static event StatusReceivedHandler StatusReceived;
        public static event LogsReceivedHandler LogsReceived;
        public static event StartReceivedHandler StartReceived;
        public static event StopReceivedHandler StopReceived;
        public static event DeleteReceivedHandler DeleteReceived;

        private static T getTypedResults<T>(Func<T> function)
        {
            return function();
        }

        private static T getTypedResults<T, TArgs>(Func<TArgs, T> function, TArgs args)
        {
            return function(args);
        }

        public static VersionResult Version()
        {
            return getTypedResults(DaemonCommander.Version);
        }


        public static StartResult Start()
        {
            StartResult result = getTypedResults(DaemonCommander.Start);

            if (StartReceived != null && result != null)
                StartReceived(result);

            return result;
        }

        public static StopResult Stop()
        {
            StopResult result = getTypedResults(DaemonCommander.Stop);

            if (StopReceived != null && result != null)
                StopReceived(result);

            return result;
        }

        public static DeleteResult Delete()
        {
            DeleteResult result = getTypedResults(DaemonCommander.Delete);

            if (DeleteReceived != null && result != null)
                DeleteReceived(result);

            return result;
        }

        public static StatusResult Status()
        {
            StatusResult result = getTypedResults(DaemonCommander.Status);

            if (StatusReceived != null && result != null)
                StatusReceived(result);

            lock (_statusChangeLock)
            {
                if (StatusChanged != null && result != null && _previousStatus != result.OpenshiftStatus)
                {
                    StatusChanged(result);

                    _previousStatus = result.OpenshiftStatus;
                }
            }

            return result;
        }

        public static LogsResult GetDaemonLogs()
        {
            LogsResult result = getTypedResults(DaemonCommander.GetLogs);

            if (LogsReceived != null && result != null)
                LogsReceived(result);

            return result;
        }

        public static ConsoleResult WebConsole()
        {
            return getTypedResults(DaemonCommander.ConsoleUrl);
        }

        public static ConfigResult ConfigView()
        {
            return getTypedResults(DaemonCommander.ConfigView);
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigSetCommand(cfg);
            return getTypedResults(DaemonCommander.SetConfig, config);
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigUnsetCommand(cfg);
            return getTypedResults(DaemonCommander.UnsetConfig, config);
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