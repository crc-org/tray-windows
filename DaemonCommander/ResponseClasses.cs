namespace tray_windows
{
    public class StatusResult
    {
        public string Name { get; set; }
        public string CrcStatus { get; set; }
        public string OpenshiftStatus { get; set; }
        public int DiskUsage { get; set; }
        public int DiskSize { get; set; }
        public string Error { get; set; }
        public bool Success { get; set; }
    }

    public class StartResult
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public ClusterConfig ClusterConfig;
        public bool KubeletStarted { get; set; }
    }

    public class ClusterConfig
    {
        public string KubeConfig { get; set; }
        public string KubeAdminPass { get; set; }
        public string ClusterAPI { get; set; }
        public string WebConsoleURL { get; set; }
    }

    public class StopResult
    {
        public string Name { get; set; }
        public bool Success { get; set; }
        public int State { get; set; }
        public string Error { get; set; }
    }

    public class DeleteResult
    {
        public string Name { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class ConsoleResult
    {
        public ClusterConfig ClusterConfig;
        public int State { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class VersionResult
    {
        public string CrcVersion { get; set; }
        public string CommitSha { get; set; }
        public string OpenshiftVersion { get; set; }
        public bool Success { get; set; }
    }
}