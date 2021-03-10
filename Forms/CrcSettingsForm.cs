using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace tray_windows
{
    public partial class CrcSettingsForm : Form
    {
        const int TotalPreflightChecks = 15;
        bool configChanged = false;
        List<string> configsNeedingUnset = new List<string>();
        ConfigResult currentConfig = new ConfigResult();
        Dictionary<string, dynamic> changedConfigs = new Dictionary<string, dynamic>();
        
        public CrcSettingsForm()
        {
            InitializeComponent();
        }

        private void CrcSettingsForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"CodeReady Containers - Settings";
            this.FormClosing += CrcSettingsForm_FormClosing;
            this.tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            

            currentConfig = Handlers.GetConfig();
            LoadConfigs(currentConfig);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var controls = tabControl1.SelectedTab.Controls.Cast<Control>();
            Console.WriteLine("Inside the handler");
            if (controls.Any())
            {
                Console.WriteLine(tabControl1.Height);
                var lastControlHeight = controls.Max(x => x.Bottom);
                tabControl1.Height = lastControlHeight + 45;
                this.Height = tabControl1.Height + 57;
                Console.WriteLine(this.Height);
                Console.WriteLine(tabControl1.Height);
            }
        }

        private void CrcSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void LoadConfigs(ConfigResult cr)
        {
            // Properties tab configs
            this.bundleTxtBox.Text = cr.Configs.bundle;
            this.memoryNumBox.Value = cr.Configs.memory;
            this.cpusNumBox.Value = cr.Configs.cpus;
            this.diskSizeNumBox.Value = cr.Configs.DiskSize;
            this.pullSecretTxtBox.Text = cr.Configs.PullSecretFile;
            //this.networkModeTxtBox.Text = cr.Configs.NetworkMode;
            this.enableExperimentalFeatures.Checked = cr.Configs.EnableExperimentalFeatures;
            // proxy configs
            if (cr.Configs.HttpProxy != "" || cr.Configs.HttpsProxy != "")
            {
                this.useProxyTick.Checked = true;
                EnableProxyFields();
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


        private void EnableProxyFields()
        {
            this.httpProxyTxtBox.Enabled = true;
            this.httpsProxyTxtBox.Enabled = true;
            this.proxyCAFileTxtBox.Enabled = true;
            this.noProxyTxtBox.Enabled = true;
        }
        // Proxy UI elements
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.useProxyTick.Checked)
            {
                EnableProxyFields();
            }
            else
            {
                this.httpProxyTxtBox.Enabled = false;
                this.httpsProxyTxtBox.Enabled = false;
                this.proxyCAFileTxtBox.Enabled = false;
                this.noProxyTxtBox.Enabled = false;
            }
        }

        private void BundleSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CRC Bundle|*.crcbundle";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            this.bundleTxtBox.Text = fileName;
        }

        private void PullSecretSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = null;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            this.pullSecretTxtBox.Text = fileName;
        }
        // refresh button on properties tab
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            currentConfig = Handlers.GetConfig();
            LoadConfigs(currentConfig);
            this.changedConfigs = new Dictionary<string, dynamic>();
            this.configsNeedingUnset = new List<string>();
        }
        // Apply button on properties tab
        private void button4_Click(object sender, EventArgs e)
        {
           if (this.configChanged && changedConfigs.Count > 0)
            {
                SetUnsetConfig r = Handlers.SetConfig(changedConfigs);
                if (r.Error == "")
                    DisplayMessageBox.Info("Properties configured: " + String.Join(",", r.Properties), "CodeReady Containers - Settings Applied");
                else
                    DisplayMessageBox.Error(r.Error);
            }
           if (this.configsNeedingUnset.Count > 0)
            {
                SetUnsetConfig r = Handlers.UnsetConfig(configsNeedingUnset);
                if (r.Error == "")
                    DisplayMessageBox.Info("Properties unset: " + String.Join(",", r.Properties), "CodeReady Containers - Settings Applied");
                else
                    DisplayMessageBox.Error(r.Error);
            }

            // Load the configs again and reset the change trackers
            currentConfig = Handlers.GetConfig();
            LoadConfigs(currentConfig);
            this.changedConfigs = new Dictionary<string, dynamic>();
            this.configsNeedingUnset = new List<string>();
        }

        private void bundleTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("bundle", currentConfig.Configs.bundle, this.bundleTxtBox);
        }

        private void cpusNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("cpus", currentConfig.Configs.cpus, this.cpusNumBox);
        }

        private void memoryNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("memory", currentConfig.Configs.memory, this.memoryNumBox);
        }

        private void pullSecretTxtBox_TextChanged(object sender, EventArgs e)
        {
            handleConfigChangesForTextBoxes("pull-secret-file", currentConfig.Configs.PullSecretFile, this.pullSecretTxtBox);
        }

        private void diskSizeNumBox_ValueChanged(object sender, EventArgs e)
        {
            handleConfigChangesForNumBoxes("disk-size", currentConfig.Configs.DiskSize, this.diskSizeNumBox);
        }

        private void enableExperimentalFeatures_CheckedChanged(object sender, EventArgs e)
        {
            handleConfigChangesForCheckBoxes("enable-experimental-features", this.enableExperimentalFeatures);
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

        private void handleConfigChangesForTextBoxes(string key, string currentConfig, TextBox txtBox)
        {
            if (txtBox.Text == currentConfig)
                return;
            else if (txtBox.Text == "")
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
            else if ((int)numBox.Value == 0 )
                this.configsNeedingUnset.Add(key);
            else
            {
                this.configChanged = true;
                if (this.changedConfigs.ContainsKey(key))
                    this.changedConfigs[key] = (int) numBox.Value;
                else
                    this.changedConfigs.Add(key, (int) numBox.Value);
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

        private void proxyCABrowseButton_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.Filter = null;
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                string fileName = openFileDialog1.FileName;
                this.proxyCAFileTxtBox.Text = fileName;
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
            
        }
    }

}
