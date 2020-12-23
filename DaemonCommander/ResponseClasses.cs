using Newtonsoft.Json;
using System;

namespace tray_windows
{
    public class StatusResult
    {
        public string Name { get; set; }
        public string CrcStatus { get; set; }
        public string OpenshiftStatus { get; set; }
        public long DiskUse { get; set; }
        public long DiskSize { get; set; }
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

    struct Config
    {
        public string bundle;
        public int cpus;
        public string nameserver;
        public int memory;

        [JsonProperty("disable-update-check")]
        public bool DisableUpdateCheck { get; set; }

        [JsonProperty("disk-size")]
        public int DiskSize {get; set;}
        
        [JsonProperty("enable-experimental-features")]
        public bool EnableExperimentalFeatures { get; set; }
        
        [JsonProperty("http-proxy")]
        public string HttpProxy { get; set; }
        
        [JsonProperty("https-proxy")]
        public string HttpsProxy { get; set; }
        
        [JsonProperty("no-proxy")]
        public string NoProxy { get; set; }
        
        [JsonProperty("proxy-ca-file")]
        public string ProxyCAFile { get; set; }
        
        [JsonProperty("pull-secret-file")]
        public string PullSecretFile { get; set; }

        [JsonProperty("network-mode")]
        public string NetworkMode { get; set; }

        [JsonProperty("skip-check-admin-helper-cached")]
        public bool SkipCheckAdminHelperCached { get; set; }

        [JsonProperty("skip-check-administrator-user")]
        public bool SkipCheckAdminUser { get; set; }

        [JsonProperty("skip-check-bundle-extracted")]
        public bool SkipCheckBundleExtracted { get; set; }

        [JsonProperty("skip-check-hyperv-installed")]
        public bool SkipCheckHypervInstalled { get; set; }

        [JsonProperty("skip-check-hyperv-service-running")]
        public bool SkipCheckHypervServiceRunning;

        [JsonProperty("skip-check-hyperv-switch")]
        public bool SkipCheckHypervSwitch { get; set; }

        [JsonProperty("skip-check-podman-cached")]
        public bool SkipCheckPodmanCached { get; set; }

        [JsonProperty("skip-check-ram")]
        public bool SkipCheckRam { get; set; }

        [JsonProperty("skip-check-user-in-hyperv-group")]
        public bool SkipCheckUserInHypervGroup { get; set; }

        [JsonProperty("skip-check-vscok")]
        public bool SkipCheckVsock { get; set; }

        [JsonProperty("skip-check-windows-edition")]
        public bool SkipCheckWindowsEdition { get; set; }

        [JsonProperty("skip-check-windows-version")]
        public bool SkipCheckWindowsVersion { get; set; }
    }

    struct ConfigResult
    {
        public string Error { get; set; }
        public Config Configs { get; set; }
    }

    struct SetUnsetConfig
    {
        public string Error;
        public string[] Properties;
    }
}