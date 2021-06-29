using System;
using System.Collections.Generic;
using CRCTray.Communication;

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

        private static T getResultsOrDefault<T>(Func<T> function)
        {
            try
            {
                return function();
            }
            catch(Exception e)
            {
                return default;
            }
        }
        private static T getResultsOrDefault<T, TArgs>(Func<TArgs, T> function, TArgs args)
        {
            try
            {
                return function(args);
            }
            catch(Exception e)
            {
                return default;
            }
        }

        public static VersionResult Version()
        {
            return getResultsOrDefault(DaemonCommander.Version);
        }


        public static StartResult Start()
        {
            StartResult result = getResultsOrDefault(DaemonCommander.Start);

            if (StartReceived != null && result != null)
                StartReceived(result);

            return result;
        }

        public static StopResult Stop()
        {
            StopResult result = getResultsOrDefault(DaemonCommander.Stop);

            if (StopReceived != null && result != null)
                StopReceived(result);

            return result;
        }

        public static DeleteResult Delete()
        {
            DeleteResult result = getResultsOrDefault(DaemonCommander.Delete);

            if (DeleteReceived != null && result != null)
                DeleteReceived(result);

            return result;
        }

        public static StatusResult Status()
        {
            StatusResult result = getResultsOrDefault(DaemonCommander.Status);

            // TODO: workaround for daemon returning 500/Error state when no VM exists
            if (result == null)
                return null;

            if (StatusReceived != null)
                StatusReceived(result);

            lock (_statusChangeLock)
            {
                if (StatusChanged != null && _previousStatus != result.OpenshiftStatus)
                    StatusChanged(result);

                _previousStatus = result.OpenshiftStatus;
            }
            return result;
        }

        public static LogsResult GetDaemonLogs()
        {
            LogsResult result = getResultsOrDefault(DaemonCommander.GetLogs);

            if (LogsReceived != null && result != null)
                LogsReceived(result);

            return result;
        }

        public static ConsoleResult WebConsole()
        {
            return getResultsOrDefault(DaemonCommander.ConsoleUrl);
        }

        public static ConfigResult ConfigView()
        {
            return getResultsOrDefault(DaemonCommander.ConfigView);
        }

        public static SetUnsetConfig SetConfig(Dictionary<string, dynamic> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigSetCommand(cfg);
            return getResultsOrDefault(DaemonCommander.SetConfig, config);
        }

        public static SetUnsetConfig UnsetConfig(List<string> cfg)
        {
            // TODO: unnecessary wrapping
            var config = new ConfigUnsetCommand(cfg);
            return getResultsOrDefault(DaemonCommander.UnsetConfig, config);
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