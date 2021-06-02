using System.Text.Json.Serialization;
using System.Windows.Forms.VisualStyles;

namespace CRCTray.Communication
{
    public class StatusResult
    {
        public string Name { get; set; }
        public string CrcStatus { get; set; }
        public string OpenshiftStatus { get; set; }
        public string OpenshiftVersion { get; set; }
        public long DiskUse { get; set; }
        public long DiskSize { get; set; }
        public string Error { get; set; }
        public bool Success { get; set; }
    }

    public class LogsResult
    {
        public bool Success { get; set; }
        public string[] Messages { get; set; }
    }

    public class StartResult
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public ClusterConfig ClusterConfig { get; set; }
        public bool KubeletStarted { get; set; }
    }

    public class ClusterConfig
    {
        public string ClusterCACert { get; set; }
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
        public ClusterConfig ClusterConfig { get; set; }
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

    struct Config
    {
        [JsonPropertyName("bundle")]
        public string bundle { get; set; }

        [JsonPropertyName("cpus")]
        public int cpus { get; set; }

        [JsonPropertyName("nameserver")]
        public string nameserver { get; set; }

        [JsonPropertyName("memory")]
        public int memory { get; set; }

        [JsonPropertyName("disable-update-check")]
        public bool DisableUpdateCheck { get; set; }

        [JsonPropertyName("disk-size")]
        public int DiskSize {get; set;}
        
        [JsonPropertyName("enable-experimental-features")]
        public bool EnableExperimentalFeatures { get; set; }
        
        [JsonPropertyName("http-proxy")]
        public string HttpProxy { get; set; }
        
        [JsonPropertyName("https-proxy")]
        public string HttpsProxy { get; set; }
        
        [JsonPropertyName("no-proxy")]
        public string NoProxy { get; set; }
        
        [JsonPropertyName("proxy-ca-file")]
        public string ProxyCAFile { get; set; }
        
        [JsonPropertyName("pull-secret-file")]
        public string PullSecretFile { get; set; }

        [JsonPropertyName("network-mode")]
        public string NetworkMode { get; set; }

        [JsonPropertyName("consent-telemetry")]
        public string ConsentTelemetry { get; set; }

        [JsonPropertyName("autostart-tray")]
        public bool AutostartTray { get; set; }

        [JsonPropertyName("skip-check-admin-helper-cached")]
        public bool SkipCheckAdminHelperCached { get; set; }

        [JsonPropertyName("skip-check-administrator-user")]
        public bool SkipCheckAdminUser { get; set; }

        [JsonPropertyName("skip-check-bundle-extracted")]
        public bool SkipCheckBundleExtracted { get; set; }

        [JsonPropertyName("skip-check-hyperv-installed")]
        public bool SkipCheckHypervInstalled { get; set; }

        [JsonPropertyName("skip-check-hyperv-service-running")]
        public bool SkipCheckHypervServiceRunning { get; set; }

        [JsonPropertyName("skip-check-hyperv-switch")]
        public bool SkipCheckHypervSwitch { get; set; }

        [JsonPropertyName("skip-check-podman-cached")]
        public bool SkipCheckPodmanCached { get; set; }

        [JsonPropertyName("skip-check-ram")]
        public bool SkipCheckRam { get; set; }

        [JsonPropertyName("skip-check-user-in-hyperv-group")]
        public bool SkipCheckUserInHypervGroup { get; set; }

        [JsonPropertyName("skip-check-vscok")]
        public bool SkipCheckVsock { get; set; }

        [JsonPropertyName("skip-check-windows-edition")]
        public bool SkipCheckWindowsEdition { get; set; }

        [JsonPropertyName("skip-check-windows-version")]
        public bool SkipCheckWindowsVersion { get; set; }
    }

    struct ConfigResult
    {
        public string Error { get; set; }
        public Config Configs { get; set; }
    }

    struct SetUnsetConfig
    {
        public string Error { get; set; }
        public string[] Properties { get; set; }
    }

}