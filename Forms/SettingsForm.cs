using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using CRCTray.Communication;
using CRCTray.Helpers;

namespace CRCTray
{
    public partial class CrcSettingsForm : Form
    {
        bool configChanged = false;
        List<string> configsNeedingUnset;
        ConfigResult currentConfig;
        Dictionary<string, dynamic> changedConfigs;
        String pullSecretContent = String.Empty;

        public CrcSettingsForm()
        {
            InitializeComponent();
            getConfigurationAndResetChanged();
        }

        private async void getConfigurationAndResetChanged()
        {
            this.changedConfigs = new Dictionary<string, dynamic>();
            this.configsNeedingUnset = new List<string>();

            currentConfig = await Task.Run(Tasks.ConfigView);
            if (currentConfig != null)
            {
                loadConfigurationValues(currentConfig);
            }
            else
            {
                TrayIcon.NotifyError("Unable to read configuration. Is the CRC daemon running?");
            }

            configChanged = false;
        }

        private void CrcSettingsForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"CodeReady Containers - Settings";
            this.FormClosing += CrcSettingsForm_FormClosing;
            this.tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var controls = tabs.SelectedTab.Controls.Cast<Control>();
            if (controls.Any())
            {
                var lastControlHeight = controls.Max(x => x.Bottom);
                tabs.Height = lastControlHeight + 45;
                this.Height = tabs.Height + 57;
            }
        }

        private void CrcSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void loadConfigurationValues(ConfigResult cr)
        {
            // Properties tab configs
            this.memoryNumBox.Value = cr.Configs.memory;
            this.cpusNumBox.Value = cr.Configs.cpus;
            this.diskSizeNumBox.Value = cr.Configs.DiskSize;
            this.consentTelemetryCheckBox.Checked = cr.Configs.ConsentTelemetry == "no" ? false : true;
            this.autostartTrayCheckBox.Checked = cr.Configs.AutostartTray;
            // proxy configs
            if (cr.Configs.HttpProxy != String.Empty || cr.Configs.HttpsProxy != String.Empty)
            {
                this.useProxyTick.Checked = true;
                enableProxyFields();
                this.httpProxyTxtBox.Text = cr.Configs.HttpProxy;
                this.httpsProxyTxtBox.Text = cr.Configs.HttpsProxy;
                this.noProxyTxtBox.Text = cr.Configs.NoProxy;
                this.proxyCAFileTxtBox.Text = cr.Configs.ProxyCAFile;
            }

            // Advanced tab configs
            this.SkipCheckRunningAsAdmin.Checked = cr.Configs.SkipCheckAdminUser;
            this.SkipCheckWindowsVersion.Checked = cr.Configs.SkipCheckWindowsVersion;
            this.SkipCheckUserInHypervAdminsGroup.Checked = cr.Configs.SkipCheckUserInHypervGroup;
            this.nameServerTxtBox.Text = cr.Configs.nameserver;
            this.disableUpdateCheckBox.Checked = cr.Configs.DisableUpdateCheck;
        }


        private void enableProxyFields()
        {
            this.httpProxyTxtBox.Enabled = true;
            this.httpsProxyTxtBox.Enabled = true;
            this.proxyCAFileTxtBox.Enabled = true;
            this.noProxyTxtBox.Enabled = true;
        }

        private void disableProxyFields()
        {
            this.httpProxyTxtBox.Enabled = false;
            this.httpsProxyTxtBox.Enabled = false;
            this.proxyCAFileTxtBox.Enabled = false;
            this.noProxyTxtBox.Enabled = false;
        }

        // Proxy UI elements
        private void useProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.useProxyTick.Checked)
            {
                enableProxyFields();
            }
            else
            {
                disableProxyFields();
            }
        }
        private string showAndGetNameFromFileRequester(string filter)
        {
            fileRequester.Filter = filter;
            fileRequester.FileName = "";
            fileRequester.ShowDialog();
            return fileRequester.FileName;
        }

        private void PullSecretChangeButton_Click(object sender, EventArgs e)
        {
            pullSecretContent = String.Empty;

            var pullSecretForm = new PullSecretForm();
            pullSecretForm.ShowDialog();

            pullSecretContent = pullSecretForm.PullSecret;

            if (pullSecretContent == String.Empty)
            {
                TrayIcon.NotifyWarn(@"No Pull Secret was provided. Cannot start cluster without pull secret.");
                return;
            }
        }

        private void proxyCABrowseButton_Click(object sender, EventArgs e)
        {
            this.proxyCAFileTxtBox.Text = showAndGetNameFromFileRequester(null);
        }

        // refresh button on properties tab
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Clear value
            pullSecretContent = String.Empty;

            getConfigurationAndResetChanged();
        }

        // Apply button on properties tab
        private async void ApplyButton_Click(object sender, EventArgs e)
        {
            TaskHelpers.TryTask(Tasks.SendTelemetry, Actions.ApplyPreferences);

            // TODO: refactor

            if (this.configChanged && changedConfigs.Count > 0) 
            {
                await TaskHelpers.TryTaskAndNotify(Tasks.SetConfig, changedConfigs,
                    "Settings applied",
                    "Settings not applied",
                    String.Empty);
            }

            if (this.configsNeedingUnset.Count > 0)
            {
                await TaskHelpers.TryTaskAndNotify(Tasks.UnsetConfig, configsNeedingUnset,
                    "Settings applied",
                    "Settings not applied",
                    String.Empty);
            }

            if(pullSecretContent != String.Empty)
            {
                await TaskHelpers.TryTaskAndNotify(Tasks.SetPullSecret, pullSecretContent,
                    "Pull Secret stored",
                    "Pull Secret not stored",
                    String.Empty);

                // Clear out value to prevent resending
                pullSecretContent = String.Empty;
            }

            // Load the configs again and reset the change trackers
            getConfigurationAndResetChanged();
        }

        private void handleConfigChangesForTextBoxes(string key, string currentConfig, TextBox txtBox)
        {
            if (txtBox.Text == currentConfig)
                return;
            else if (txtBox.Text == String.Empty)
                this.configsNeedingUnset.Add(key);
            else
            {
                this.configChanged = true;
                if (this.changedConfigs.ContainsKey(key))
                    this.changedConfigs[key] = txtBox.Text;
                else
                    this.changedConfigs.Add(key, txtBox.Text);
            }
        }

        private void handleConfigChangesForNumBoxes(string key, int currentConfig, NumericUpDown numBox)
        {
            if (numBox.Value == currentConfig)
                return;
            else if ((int)numBox.Value == 0)
                this.configsNeedingUnset.Add(key);
            else
            {
                this.configChanged = true;
                if (this.changedConfigs.ContainsKey(key))
                    this.changedConfigs[key] = (int)numBox.Value;
                else
                    this.changedConfigs.Add(key, (int)numBox.Value);
            }
        }

        private void handleConfigChangesForCheckBoxes(string key, CheckBox cb)
        {
            this.configChanged = true;
            if (this.changedConfigs.ContainsKey(key))
                this.changedConfigs[key] = cb.Checked;
            else
                this.changedConfigs.Add(key, cb.Checked);
        }

        private void cpusNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("cpus", currentConfig.Configs.cpus, this.cpusNumBox);
        }

        private void memoryNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("memory", currentConfig.Configs.memory, this.memoryNumBox);
        }

        private void diskSizeNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("disk-size", currentConfig.Configs.DiskSize, this.diskSizeNumBox);
        }

        private void httpProxyTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("http-proxy", currentConfig.Configs.HttpProxy, this.httpProxyTxtBox);
        }

        private void httpsProxyTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("https-proxy", currentConfig.Configs.HttpsProxy, this.httpsProxyTxtBox);
        }

        private void noProxyTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("no-proxy", currentConfig.Configs.NoProxy, this.noProxyTxtBox);
        }

        private void proxyCAFileTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("proxy-ca-file", currentConfig.Configs.ProxyCAFile, this.proxyCAFileTxtBox);
        }

        private void disableUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("disable-update-check", this.disableUpdateCheckBox);
        }

        private void nameServerTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("nameserver", currentConfig.Configs.nameserver, this.nameServerTxtBox);
        }

        private void SkipCheckRunningAsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("skip-check-administrator-user", this.SkipCheckRunningAsAdmin);
        }

        private void SkipCheckWindowsVersion_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("skip-check-windows-version", this.SkipCheckWindowsVersion);
        }

        private void SkipCheckUserInHypervAdminsGroup_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("skip-check-user-in-hyperv-group", this.SkipCheckUserInHypervAdminsGroup);
        }

        private void consentTelemetryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var key = "consent-telemetry";
            var cb = (CheckBox)sender;
            var value = cb.Checked ? "yes" : "no";

            this.configChanged = true;
            if (this.changedConfigs.ContainsKey(key))
                this.changedConfigs[key] = value;
            else
                this.changedConfigs.Add(key, value);
        }

        private void autostartTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("autostart-tray", this.autostartTrayCheckBox);
        }
    }
}
