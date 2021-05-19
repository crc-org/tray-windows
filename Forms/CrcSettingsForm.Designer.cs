namespace CRCTray
{
    partial class CrcSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.properties_tab = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.proxyCABrowseButton = new System.Windows.Forms.Button();
            this.proxyCAFileTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noProxyTxtBox = new System.Windows.Forms.TextBox();
            this.httpsProxyTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.httpProxyTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.useProxyTick = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consentTelemetryCheckBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.diskSizeNumBox = new System.Windows.Forms.NumericUpDown();
            this.memoryNumBox = new System.Windows.Forms.NumericUpDown();
            this.cpusNumBox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.PullSecretSelectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pullSecretTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advance_tab = new System.Windows.Forms.TabPage();
            this.refreshButton2 = new System.Windows.Forms.Button();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autostartTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.nameServerTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.disableUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SkipCheckWindowsVersion = new System.Windows.Forms.CheckBox();
            this.SkipCheckRunningAsAdmin = new System.Windows.Forms.CheckBox();
            this.SkipCheckUserInHypervAdminsGroup = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileRequester = new System.Windows.Forms.OpenFileDialog();
            this.tabs.SuspendLayout();
            this.properties_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpusNumBox)).BeginInit();
            this.advance_tab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AccessibleName = "Settings tab";
            this.tabs.Controls.Add(this.properties_tab);
            this.tabs.Controls.Add(this.advance_tab);
            this.tabs.Location = new System.Drawing.Point(9, 9);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(628, 460);
            this.tabs.TabIndex = 0;
            // 
            // properties_tab
            // 
            this.properties_tab.Controls.Add(this.applyButton);
            this.properties_tab.Controls.Add(this.refreshButton);
            this.properties_tab.Controls.Add(this.groupBox2);
            this.properties_tab.Controls.Add(this.groupBox1);
            this.properties_tab.Location = new System.Drawing.Point(4, 25);
            this.properties_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.properties_tab.Name = "properties_tab";
            this.properties_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.properties_tab.Size = new System.Drawing.Size(620, 431);
            this.properties_tab.TabIndex = 0;
            this.properties_tab.Text = "Properties";
            this.properties_tab.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.AccessibleName = "Apply button";
            this.applyButton.Location = new System.Drawing.Point(524, 398);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(83, 26);
            this.applyButton.TabIndex = 15;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleName = "Refresh button";
            this.refreshButton.Location = new System.Drawing.Point(408, 398);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 26);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.proxyCABrowseButton);
            this.groupBox2.Controls.Add(this.proxyCAFileTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.noProxyTxtBox);
            this.groupBox2.Controls.Add(this.httpsProxyTxtBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.httpProxyTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.useProxyTick);
            this.groupBox2.Location = new System.Drawing.Point(4, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(607, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proxy";
            // 
            // proxyCABrowseButton
            // 
            this.proxyCABrowseButton.AccessibleName = "Proxy CA filerequester";
            this.proxyCABrowseButton.Location = new System.Drawing.Point(520, 142);
            this.proxyCABrowseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proxyCABrowseButton.Name = "proxyCABrowseButton";
            this.proxyCABrowseButton.Size = new System.Drawing.Size(83, 27);
            this.proxyCABrowseButton.TabIndex = 13;
            this.proxyCABrowseButton.Text = "Select file";
            this.proxyCABrowseButton.UseVisualStyleBackColor = true;
            this.proxyCABrowseButton.Click += new System.EventHandler(this.proxyCABrowseButton_Click);
            // 
            // proxyCAFileTxtBox
            // 
            this.proxyCAFileTxtBox.AccessibleName = "Proxy CA file";
            this.proxyCAFileTxtBox.Enabled = false;
            this.proxyCAFileTxtBox.Location = new System.Drawing.Point(140, 143);
            this.proxyCAFileTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proxyCAFileTxtBox.Name = "proxyCAFileTxtBox";
            this.proxyCAFileTxtBox.Size = new System.Drawing.Size(345, 22);
            this.proxyCAFileTxtBox.TabIndex = 12;
            this.proxyCAFileTxtBox.TextChanged += new System.EventHandler(this.proxyCAFileTxtBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proxy CA file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Proxy(s)";
            // 
            // noProxyTxtBox
            // 
            this.noProxyTxtBox.AccessibleName = "No proxy";
            this.noProxyTxtBox.Enabled = false;
            this.noProxyTxtBox.Location = new System.Drawing.Point(140, 110);
            this.noProxyTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noProxyTxtBox.Name = "noProxyTxtBox";
            this.noProxyTxtBox.Size = new System.Drawing.Size(345, 22);
            this.noProxyTxtBox.TabIndex = 11;
            this.noProxyTxtBox.TextChanged += new System.EventHandler(this.noProxyTxtBox_TextChanged);
            // 
            // httpsProxyTxtBox
            // 
            this.httpsProxyTxtBox.AccessibleName = "HTTPS proxy";
            this.httpsProxyTxtBox.Enabled = false;
            this.httpsProxyTxtBox.Location = new System.Drawing.Point(140, 78);
            this.httpsProxyTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.httpsProxyTxtBox.Name = "httpsProxyTxtBox";
            this.httpsProxyTxtBox.Size = new System.Drawing.Size(345, 22);
            this.httpsProxyTxtBox.TabIndex = 10;
            this.httpsProxyTxtBox.TextChanged += new System.EventHandler(this.httpsProxyTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "HTTPS Proxy";
            // 
            // httpProxyTxtBox
            // 
            this.httpProxyTxtBox.AccessibleName = "HTTP proxy";
            this.httpProxyTxtBox.Enabled = false;
            this.httpProxyTxtBox.Location = new System.Drawing.Point(140, 46);
            this.httpProxyTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.httpProxyTxtBox.Name = "httpProxyTxtBox";
            this.httpProxyTxtBox.Size = new System.Drawing.Size(345, 22);
            this.httpProxyTxtBox.TabIndex = 9;
            this.httpProxyTxtBox.TextChanged += new System.EventHandler(this.httpProxyTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "HTTP Proxy";
            // 
            // useProxyTick
            // 
            this.useProxyTick.AccessibleName = "Use proxy";
            this.useProxyTick.AutoSize = true;
            this.useProxyTick.Location = new System.Drawing.Point(8, 18);
            this.useProxyTick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useProxyTick.Name = "useProxyTick";
            this.useProxyTick.Size = new System.Drawing.Size(94, 21);
            this.useProxyTick.TabIndex = 8;
            this.useProxyTick.Text = "Use Proxy";
            this.useProxyTick.UseVisualStyleBackColor = true;
            this.useProxyTick.CheckedChanged += new System.EventHandler(this.useProxy_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.consentTelemetryCheckBox);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.diskSizeNumBox);
            this.groupBox1.Controls.Add(this.memoryNumBox);
            this.groupBox1.Controls.Add(this.cpusNumBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PullSecretSelectButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pullSecretTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(607, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // consentTelemetryCheckBox
            // 
            this.consentTelemetryCheckBox.AutoSize = true;
            this.consentTelemetryCheckBox.Location = new System.Drawing.Point(8, 150);
            this.consentTelemetryCheckBox.Name = "consentTelemetryCheckBox";
            this.consentTelemetryCheckBox.Size = new System.Drawing.Size(207, 21);
            this.consentTelemetryCheckBox.TabIndex = 17;
            this.consentTelemetryCheckBox.Text = "Report telemetry to Red Hat";
            this.consentTelemetryCheckBox.UseVisualStyleBackColor = true;
            this.consentTelemetryCheckBox.CheckedChanged += new System.EventHandler(this.consentTelemetryCheckBox_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(197, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "GB";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 17);
            this.label22.TabIndex = 15;
            this.label22.Text = "Disk Size";
            // 
            // diskSizeNumBox
            // 
            this.diskSizeNumBox.AccessibleName = "Disk size";
            this.diskSizeNumBox.Location = new System.Drawing.Point(105, 119);
            this.diskSizeNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diskSizeNumBox.Name = "diskSizeNumBox";
            this.diskSizeNumBox.Size = new System.Drawing.Size(87, 22);
            this.diskSizeNumBox.TabIndex = 7;
            this.diskSizeNumBox.ValueChanged += new System.EventHandler(this.diskSizeNumBox_ValueChanged);
            // 
            // memoryNumBox
            // 
            this.memoryNumBox.AccessibleName = "Memory";
            this.memoryNumBox.Location = new System.Drawing.Point(105, 53);
            this.memoryNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoryNumBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.memoryNumBox.Name = "memoryNumBox";
            this.memoryNumBox.Size = new System.Drawing.Size(87, 22);
            this.memoryNumBox.TabIndex = 4;
            this.memoryNumBox.Value = new decimal(new int[] {
            9126,
            0,
            0,
            0});
            this.memoryNumBox.ValueChanged += new System.EventHandler(this.memoryNumBox_ValueChanged);
            // 
            // cpusNumBox
            // 
            this.cpusNumBox.AccessibleName = "vCPUs";
            this.cpusNumBox.Location = new System.Drawing.Point(105, 21);
            this.cpusNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpusNumBox.Name = "cpusNumBox";
            this.cpusNumBox.Size = new System.Drawing.Size(87, 22);
            this.cpusNumBox.TabIndex = 3;
            this.cpusNumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cpusNumBox.ValueChanged += new System.EventHandler(this.cpusNumBox_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "MB";
            // 
            // PullSecretSelectButton
            // 
            this.PullSecretSelectButton.AccessibleName = "PullSecret filerequester";
            this.PullSecretSelectButton.Location = new System.Drawing.Point(520, 82);
            this.PullSecretSelectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PullSecretSelectButton.Name = "PullSecretSelectButton";
            this.PullSecretSelectButton.Size = new System.Drawing.Size(83, 26);
            this.PullSecretSelectButton.TabIndex = 6;
            this.PullSecretSelectButton.Text = "Select file";
            this.PullSecretSelectButton.UseVisualStyleBackColor = true;
            this.PullSecretSelectButton.Click += new System.EventHandler(this.PullSecretSelectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pull secret file";
            // 
            // pullSecretTxtBox
            // 
            this.pullSecretTxtBox.AccessibleName = "PullSecret location";
            this.pullSecretTxtBox.Location = new System.Drawing.Point(105, 86);
            this.pullSecretTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pullSecretTxtBox.Name = "pullSecretTxtBox";
            this.pullSecretTxtBox.Size = new System.Drawing.Size(379, 22);
            this.pullSecretTxtBox.TabIndex = 5;
            this.pullSecretTxtBox.TextChanged += new System.EventHandler(this.pullSecretTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPUs";
            // 
            // advance_tab
            // 
            this.advance_tab.Controls.Add(this.refreshButton2);
            this.advance_tab.Controls.Add(this.applyButton2);
            this.advance_tab.Controls.Add(this.groupBox4);
            this.advance_tab.Controls.Add(this.groupBox3);
            this.advance_tab.Location = new System.Drawing.Point(4, 25);
            this.advance_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advance_tab.Name = "advance_tab";
            this.advance_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advance_tab.Size = new System.Drawing.Size(620, 431);
            this.advance_tab.TabIndex = 1;
            this.advance_tab.Text = "Advanced";
            this.advance_tab.UseVisualStyleBackColor = true;
            // 
            // refreshButton2
            // 
            this.refreshButton2.AccessibleName = "Refresh button";
            this.refreshButton2.Location = new System.Drawing.Point(405, 266);
            this.refreshButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton2.Name = "refreshButton2";
            this.refreshButton2.Size = new System.Drawing.Size(81, 27);
            this.refreshButton2.TabIndex = 22;
            this.refreshButton2.Text = "Refresh";
            this.refreshButton2.UseVisualStyleBackColor = true;
            this.refreshButton2.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // applyButton2
            // 
            this.applyButton2.AccessibleName = "Apply button";
            this.applyButton2.Location = new System.Drawing.Point(524, 266);
            this.applyButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(84, 27);
            this.applyButton2.TabIndex = 23;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = true;
            this.applyButton2.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autostartTrayCheckBox);
            this.groupBox4.Controls.Add(this.nameServerTxtBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.disableUpdateCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(5, 144);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(607, 102);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // autostartTrayCheckBox
            // 
            this.autostartTrayCheckBox.AutoSize = true;
            this.autostartTrayCheckBox.Location = new System.Drawing.Point(4, 66);
            this.autostartTrayCheckBox.Name = "autostartTrayCheckBox";
            this.autostartTrayCheckBox.Size = new System.Drawing.Size(199, 21);
            this.autostartTrayCheckBox.TabIndex = 21;
            this.autostartTrayCheckBox.Text = "Automatically start on login";
            this.autostartTrayCheckBox.UseVisualStyleBackColor = true;
            this.autostartTrayCheckBox.CheckedChanged += new System.EventHandler(this.autostartTrayCheckBox_CheckedChanged);
            // 
            // nameServerTxtBox
            // 
            this.nameServerTxtBox.AccessibleName = "Nameserver";
            this.nameServerTxtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1.1.1.1",
            "8.8.8.8",
            "1.0.0.1"});
            this.nameServerTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nameServerTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameServerTxtBox.Location = new System.Drawing.Point(451, 26);
            this.nameServerTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameServerTxtBox.Name = "nameServerTxtBox";
            this.nameServerTxtBox.Size = new System.Drawing.Size(153, 22);
            this.nameServerTxtBox.TabIndex = 20;
            this.nameServerTxtBox.TextChanged += new System.EventHandler(this.nameServerTxtBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nameserver";
            // 
            // disableUpdateCheckBox
            // 
            this.disableUpdateCheckBox.AccessibleName = "Disable update check";
            this.disableUpdateCheckBox.AutoSize = true;
            this.disableUpdateCheckBox.Location = new System.Drawing.Point(4, 26);
            this.disableUpdateCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disableUpdateCheckBox.Name = "disableUpdateCheckBox";
            this.disableUpdateCheckBox.Size = new System.Drawing.Size(166, 21);
            this.disableUpdateCheckBox.TabIndex = 19;
            this.disableUpdateCheckBox.Text = "Disable update check";
            this.disableUpdateCheckBox.UseVisualStyleBackColor = true;
            this.disableUpdateCheckBox.CheckedChanged += new System.EventHandler(this.disableUpdateCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(607, 134);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preflight Checks";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.11136F));
            this.tableLayoutPanel1.Controls.Add(this.SkipCheckWindowsVersion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SkipCheckRunningAsAdmin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SkipCheckUserInHypervAdminsGroup, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 97);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // SkipCheckWindowsVersion
            // 
            this.SkipCheckWindowsVersion.AccessibleName = "Skip Windows version check";
            this.SkipCheckWindowsVersion.AutoSize = true;
            this.SkipCheckWindowsVersion.Location = new System.Drawing.Point(4, 68);
            this.SkipCheckWindowsVersion.Margin = new System.Windows.Forms.Padding(4);
            this.SkipCheckWindowsVersion.Name = "SkipCheckWindowsVersion";
            this.SkipCheckWindowsVersion.Size = new System.Drawing.Size(204, 21);
            this.SkipCheckWindowsVersion.TabIndex = 18;
            this.SkipCheckWindowsVersion.Text = "Skip windows version check";
            this.SkipCheckWindowsVersion.UseVisualStyleBackColor = true;
            this.SkipCheckWindowsVersion.CheckedChanged += new System.EventHandler(this.SkipCheckWindowsVersion_CheckedChanged);
            // 
            // SkipCheckRunningAsAdmin
            // 
            this.SkipCheckRunningAsAdmin.AccessibleDescription = "Skip check if user is administrator";
            this.SkipCheckRunningAsAdmin.AccessibleName = "Skip administrator check";
            this.SkipCheckRunningAsAdmin.AutoSize = true;
            this.SkipCheckRunningAsAdmin.Location = new System.Drawing.Point(4, 36);
            this.SkipCheckRunningAsAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.SkipCheckRunningAsAdmin.Name = "SkipCheckRunningAsAdmin";
            this.SkipCheckRunningAsAdmin.Size = new System.Drawing.Size(264, 21);
            this.SkipCheckRunningAsAdmin.TabIndex = 17;
            this.SkipCheckRunningAsAdmin.Text = "Skip check for running as admin user";
            this.SkipCheckRunningAsAdmin.UseVisualStyleBackColor = true;
            this.SkipCheckRunningAsAdmin.CheckedChanged += new System.EventHandler(this.SkipCheckRunningAsAdmin_CheckedChanged);
            // 
            // SkipCheckUserInHypervAdminsGroup
            // 
            this.SkipCheckUserInHypervAdminsGroup.AccessibleDescription = "Skip check if user in Hyper-V administrators group";
            this.SkipCheckUserInHypervAdminsGroup.AccessibleName = "Skip Hyper-V admin check";
            this.SkipCheckUserInHypervAdminsGroup.AutoSize = true;
            this.SkipCheckUserInHypervAdminsGroup.Location = new System.Drawing.Point(4, 4);
            this.SkipCheckUserInHypervAdminsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.SkipCheckUserInHypervAdminsGroup.Name = "SkipCheckUserInHypervAdminsGroup";
            this.SkipCheckUserInHypervAdminsGroup.Size = new System.Drawing.Size(282, 21);
            this.SkipCheckUserInHypervAdminsGroup.TabIndex = 16;
            this.SkipCheckUserInHypervAdminsGroup.Text = "Skip user in hyperv admins group check";
            this.SkipCheckUserInHypervAdminsGroup.UseVisualStyleBackColor = true;
            this.SkipCheckUserInHypervAdminsGroup.CheckedChanged += new System.EventHandler(this.SkipCheckUserInHypervAdminsGroup_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileRequester
            // 
            this.fileRequester.FileName = "openFileDialog1";
            this.fileRequester.InitialDirectory = "$env:USERPROFILE";
            // 
            // CrcSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 476);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrcSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.CrcSettingsForm_Load);
            this.tabs.ResumeLayout(false);
            this.properties_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpusNumBox)).EndInit();
            this.advance_tab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage properties_tab;
        private System.Windows.Forms.TabPage advance_tab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PullSecretSelectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pullSecretTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox useProxyTick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noProxyTxtBox;
        private System.Windows.Forms.TextBox httpsProxyTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox httpProxyTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button proxyCABrowseButton;
        private System.Windows.Forms.TextBox proxyCAFileTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.OpenFileDialog fileRequester;
        private System.Windows.Forms.TextBox nameServerTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox disableUpdateCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button refreshButton2;
        private System.Windows.Forms.Button applyButton2;
        private System.Windows.Forms.NumericUpDown memoryNumBox;
        private System.Windows.Forms.NumericUpDown cpusNumBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown diskSizeNumBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox SkipCheckWindowsVersion;
        private System.Windows.Forms.CheckBox SkipCheckRunningAsAdmin;
        private System.Windows.Forms.CheckBox SkipCheckUserInHypervAdminsGroup;
        private System.Windows.Forms.CheckBox autostartTrayCheckBox;
        private System.Windows.Forms.CheckBox consentTelemetryCheckBox;
    }
}