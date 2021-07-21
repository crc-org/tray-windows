namespace CRCTray.Communication
{
    static class BasicCommands
    {
        internal const string Status = "status";
        internal const string Version = "version";

        internal const string Start = "start";
        internal const string Stop = "stop";
        internal const string Delete = "delete";

        internal const string ConsoleUrl = "webconsoleurl";
        internal const string Logs = "logs";
        internal const string Telemetry = "telemetry";

        // TODO: use proper GET/POST verbs
        internal const string ConfigGet = "config/get";
        internal const string ConfigSet = "config/set";
        internal const string ConfigUnset = "config/unset";

        internal const string PullSecret = "pull-secret";
    }
}