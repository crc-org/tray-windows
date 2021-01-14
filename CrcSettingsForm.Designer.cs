namespace tray_windows
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.properties_tab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
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
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.diskSizeNumBox = new System.Windows.Forms.NumericUpDown();
            this.memoryNumBox = new System.Windows.Forms.NumericUpDown();
            this.cpusNumBox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.PullSecretSelectButton = new System.Windows.Forms.Button();
            this.BundleSelectButton = new System.Windows.Forms.Button();
            this.enableExperimentalFeatures = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pullSecretTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bundleTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.advance_tab = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nameServerTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.disableUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SkipCheckUserInHypervAdminsGroup = new System.Windows.Forms.CheckBox();
            this.SkipCheckRunningAsAdmin = new System.Windows.Forms.CheckBox();
            this.SkipCheckWindowsVersion = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.properties_tab);
            this.tabControl1.Controls.Add(this.advance_tab);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // properties_tab
            // 
            this.properties_tab.Controls.Add(this.button4);
            this.properties_tab.Controls.Add(this.refresh_button);
            this.properties_tab.Controls.Add(this.groupBox2);
            this.properties_tab.Controls.Add(this.groupBox1);
            this.properties_tab.Location = new System.Drawing.Point(4, 22);
            this.properties_tab.Margin = new System.Windows.Forms.Padding(2);
            this.properties_tab.Name = "properties_tab";
            this.properties_tab.Padding = new System.Windows.Forms.Padding(2);
            this.properties_tab.Size = new System.Drawing.Size(463, 348);
            this.properties_tab.TabIndex = 0;
            this.properties_tab.Text = "Properties";
            this.properties_tab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 320);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 21);
            this.button4.TabIndex = 10;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(306, 320);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(2);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(60, 21);
            this.refresh_button.TabIndex = 11;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(455, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proxy";
            // 
            // proxyCABrowseButton
            // 
            this.proxyCABrowseButton.Location = new System.Drawing.Point(390, 115);
            this.proxyCABrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.proxyCABrowseButton.Name = "proxyCABrowseButton";
            this.proxyCABrowseButton.Size = new System.Drawing.Size(62, 22);
            this.proxyCABrowseButton.TabIndex = 9;
            this.proxyCABrowseButton.Text = "Select file";
            this.proxyCABrowseButton.UseVisualStyleBackColor = true;
            this.proxyCABrowseButton.Click += new System.EventHandler(this.proxyCABrowseButton_Click);
            // 
            // proxyCAFileTxtBox
            // 
            this.proxyCAFileTxtBox.Enabled = false;
            this.proxyCAFileTxtBox.Location = new System.Drawing.Point(105, 116);
            this.proxyCAFileTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.proxyCAFileTxtBox.Name = "proxyCAFileTxtBox";
            this.proxyCAFileTxtBox.Size = new System.Drawing.Size(260, 20);
            this.proxyCAFileTxtBox.TabIndex = 8;
            this.proxyCAFileTxtBox.TextChanged += new System.EventHandler(this.proxyCAFileTxtBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proxy CA file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Proxy(s)";
            // 
            // noProxyTxtBox
            // 
            this.noProxyTxtBox.Enabled = false;
            this.noProxyTxtBox.Location = new System.Drawing.Point(105, 89);
            this.noProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.noProxyTxtBox.Name = "noProxyTxtBox";
            this.noProxyTxtBox.Size = new System.Drawing.Size(260, 20);
            this.noProxyTxtBox.TabIndex = 5;
            this.noProxyTxtBox.TextChanged += new System.EventHandler(this.noProxyTxtBox_TextChanged);
            // 
            // httpsProxyTxtBox
            // 
            this.httpsProxyTxtBox.Enabled = false;
            this.httpsProxyTxtBox.Location = new System.Drawing.Point(105, 63);
            this.httpsProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.httpsProxyTxtBox.Name = "httpsProxyTxtBox";
            this.httpsProxyTxtBox.Size = new System.Drawing.Size(260, 20);
            this.httpsProxyTxtBox.TabIndex = 4;
            this.httpsProxyTxtBox.TextChanged += new System.EventHandler(this.httpsProxyTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "HTTPS Proxy";
            // 
            // httpProxyTxtBox
            // 
            this.httpProxyTxtBox.Enabled = false;
            this.httpProxyTxtBox.Location = new System.Drawing.Point(105, 37);
            this.httpProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.httpProxyTxtBox.Name = "httpProxyTxtBox";
            this.httpProxyTxtBox.Size = new System.Drawing.Size(260, 20);
            this.httpProxyTxtBox.TabIndex = 2;
            this.httpProxyTxtBox.TextChanged += new System.EventHandler(this.httpProxyTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HTTP Proxy";
            // 
            // useProxyTick
            // 
            this.useProxyTick.AutoSize = true;
            this.useProxyTick.Location = new System.Drawing.Point(6, 15);
            this.useProxyTick.Margin = new System.Windows.Forms.Padding(2);
            this.useProxyTick.Name = "useProxyTick";
            this.useProxyTick.Size = new System.Drawing.Size(74, 17);
            this.useProxyTick.TabIndex = 0;
            this.useProxyTick.Text = "Use Proxy";
            this.useProxyTick.UseVisualStyleBackColor = true;
            this.useProxyTick.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.diskSizeNumBox);
            this.groupBox1.Controls.Add(this.memoryNumBox);
            this.groupBox1.Controls.Add(this.cpusNumBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PullSecretSelectButton);
            this.groupBox1.Controls.Add(this.BundleSelectButton);
            this.groupBox1.Controls.Add(this.enableExperimentalFeatures);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pullSecretTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bundleTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(455, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(148, 119);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "GB";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 118);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Disk Size";
            // 
            // diskSizeNumBox
            // 
            this.diskSizeNumBox.Location = new System.Drawing.Point(79, 117);
            this.diskSizeNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.diskSizeNumBox.Name = "diskSizeNumBox";
            this.diskSizeNumBox.Size = new System.Drawing.Size(65, 20);
            this.diskSizeNumBox.TabIndex = 14;
            this.diskSizeNumBox.ValueChanged += new System.EventHandler(this.diskSizeNumBox_ValueChanged);
            // 
            // memoryNumBox
            // 
            this.memoryNumBox.Location = new System.Drawing.Point(79, 64);
            this.memoryNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.memoryNumBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.memoryNumBox.Minimum = new decimal(new int[] {
            9126,
            0,
            0,
            0});
            this.memoryNumBox.Name = "memoryNumBox";
            this.memoryNumBox.Size = new System.Drawing.Size(65, 20);
            this.memoryNumBox.TabIndex = 13;
            this.memoryNumBox.Value = new decimal(new int[] {
            9126,
            0,
            0,
            0});
            this.memoryNumBox.ValueChanged += new System.EventHandler(this.memoryNumBox_ValueChanged);
            // 
            // cpusNumBox
            // 
            this.cpusNumBox.Location = new System.Drawing.Point(79, 38);
            this.cpusNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpusNumBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cpusNumBox.Name = "cpusNumBox";
            this.cpusNumBox.Size = new System.Drawing.Size(65, 20);
            this.cpusNumBox.TabIndex = 12;
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
            this.label11.Location = new System.Drawing.Point(147, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "MB";
            // 
            // PullSecretSelectButton
            // 
            this.PullSecretSelectButton.Location = new System.Drawing.Point(390, 87);
            this.PullSecretSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.PullSecretSelectButton.Name = "PullSecretSelectButton";
            this.PullSecretSelectButton.Size = new System.Drawing.Size(62, 21);
            this.PullSecretSelectButton.TabIndex = 10;
            this.PullSecretSelectButton.Text = "Select file";
            this.PullSecretSelectButton.UseVisualStyleBackColor = true;
            this.PullSecretSelectButton.Click += new System.EventHandler(this.PullSecretSelectButton_Click);
            // 
            // BundleSelectButton
            // 
            this.BundleSelectButton.Location = new System.Drawing.Point(390, 10);
            this.BundleSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.BundleSelectButton.Name = "BundleSelectButton";
            this.BundleSelectButton.Size = new System.Drawing.Size(62, 20);
            this.BundleSelectButton.TabIndex = 9;
            this.BundleSelectButton.Text = "Select file";
            this.BundleSelectButton.UseVisualStyleBackColor = true;
            this.BundleSelectButton.Click += new System.EventHandler(this.BundleSelectButton_Click);
            // 
            // enableExperimentalFeatures
            // 
            this.enableExperimentalFeatures.AutoSize = true;
            this.enableExperimentalFeatures.Location = new System.Drawing.Point(213, 118);
            this.enableExperimentalFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.enableExperimentalFeatures.Name = "enableExperimentalFeatures";
            this.enableExperimentalFeatures.Size = new System.Drawing.Size(162, 17);
            this.enableExperimentalFeatures.TabIndex = 8;
            this.enableExperimentalFeatures.Text = "Enable experimental features";
            this.enableExperimentalFeatures.UseVisualStyleBackColor = true;
            this.enableExperimentalFeatures.CheckedChanged += new System.EventHandler(this.enableExperimentalFeatures_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pull secret file";
            // 
            // pullSecretTxtBox
            // 
            this.pullSecretTxtBox.Location = new System.Drawing.Point(79, 90);
            this.pullSecretTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.pullSecretTxtBox.Name = "pullSecretTxtBox";
            this.pullSecretTxtBox.Size = new System.Drawing.Size(285, 20);
            this.pullSecretTxtBox.TabIndex = 6;
            this.pullSecretTxtBox.TextChanged += new System.EventHandler(this.pullSecretTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPUs";
            // 
            // bundleTxtBox
            // 
            this.bundleTxtBox.Location = new System.Drawing.Point(79, 11);
            this.bundleTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.bundleTxtBox.Name = "bundleTxtBox";
            this.bundleTxtBox.Size = new System.Drawing.Size(285, 20);
            this.bundleTxtBox.TabIndex = 1;
            this.bundleTxtBox.TextChanged += new System.EventHandler(this.bundleTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bundle";
            // 
            // advance_tab
            // 
            this.advance_tab.Controls.Add(this.button7);
            this.advance_tab.Controls.Add(this.button6);
            this.advance_tab.Controls.Add(this.groupBox4);
            this.advance_tab.Controls.Add(this.groupBox3);
            this.advance_tab.Location = new System.Drawing.Point(4, 22);
            this.advance_tab.Margin = new System.Windows.Forms.Padding(2);
            this.advance_tab.Name = "advance_tab";
            this.advance_tab.Padding = new System.Windows.Forms.Padding(2);
            this.advance_tab.Size = new System.Drawing.Size(463, 348);
            this.advance_tab.TabIndex = 1;
            this.advance_tab.Text = "Advanced";
            this.advance_tab.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(304, 187);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 22);
            this.button7.TabIndex = 2;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(393, 187);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 22);
            this.button6.TabIndex = 0;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nameServerTxtBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.disableUpdateCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(4, 117);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(455, 53);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // nameServerTxtBox
            // 
            this.nameServerTxtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1.1.1.1",
            "8.8.8.8",
            "1.0.0.1"});
            this.nameServerTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nameServerTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameServerTxtBox.Location = new System.Drawing.Point(338, 21);
            this.nameServerTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameServerTxtBox.Name = "nameServerTxtBox";
            this.nameServerTxtBox.Size = new System.Drawing.Size(116, 20);
            this.nameServerTxtBox.TabIndex = 2;
            this.nameServerTxtBox.TextChanged += new System.EventHandler(this.nameServerTxtBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nameserver";
            // 
            // disableUpdateCheckBox
            // 
            this.disableUpdateCheckBox.AutoSize = true;
            this.disableUpdateCheckBox.Location = new System.Drawing.Point(3, 21);
            this.disableUpdateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.disableUpdateCheckBox.Name = "disableUpdateCheckBox";
            this.disableUpdateCheckBox.Size = new System.Drawing.Size(130, 17);
            this.disableUpdateCheckBox.TabIndex = 0;
            this.disableUpdateCheckBox.Text = "Disable update check";
            this.disableUpdateCheckBox.UseVisualStyleBackColor = true;
            this.disableUpdateCheckBox.CheckedChanged += new System.EventHandler(this.disableUpdateCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(455, 109);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 79);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "$env:USERPROFILE";
            // 
            // SkipCheckUserInHypervAdminsGroup
            // 
            this.SkipCheckUserInHypervAdminsGroup.AutoSize = true;
            this.SkipCheckUserInHypervAdminsGroup.Location = new System.Drawing.Point(3, 3);
            this.SkipCheckUserInHypervAdminsGroup.Name = "SkipCheckUserInHypervAdminsGroup";
            this.SkipCheckUserInHypervAdminsGroup.Size = new System.Drawing.Size(215, 17);
            this.SkipCheckUserInHypervAdminsGroup.TabIndex = 7;
            this.SkipCheckUserInHypervAdminsGroup.Text = "Skip user in hyperv admins group check";
            this.SkipCheckUserInHypervAdminsGroup.UseVisualStyleBackColor = true;
            this.SkipCheckUserInHypervAdminsGroup.CheckedChanged += new System.EventHandler(this.SkipCheckUserInHypervAdminsGroup_CheckedChanged);
            // 
            // SkipCheckRunningAsAdmin
            // 
            this.SkipCheckRunningAsAdmin.AutoSize = true;
            this.SkipCheckRunningAsAdmin.Location = new System.Drawing.Point(3, 29);
            this.SkipCheckRunningAsAdmin.Name = "SkipCheckRunningAsAdmin";
            this.SkipCheckRunningAsAdmin.Size = new System.Drawing.Size(201, 17);
            this.SkipCheckRunningAsAdmin.TabIndex = 8;
            this.SkipCheckRunningAsAdmin.Text = "Skip check for running as admin user";
            this.SkipCheckRunningAsAdmin.UseVisualStyleBackColor = true;
            this.SkipCheckRunningAsAdmin.CheckedChanged += new System.EventHandler(this.SkipCheckRunningAsAdmin_CheckedChanged);
            // 
            // SkipCheckWindowsVersion
            // 
            this.SkipCheckWindowsVersion.AutoSize = true;
            this.SkipCheckWindowsVersion.Location = new System.Drawing.Point(3, 55);
            this.SkipCheckWindowsVersion.Name = "SkipCheckWindowsVersion";
            this.SkipCheckWindowsVersion.Size = new System.Drawing.Size(161, 17);
            this.SkipCheckWindowsVersion.TabIndex = 9;
            this.SkipCheckWindowsVersion.Text = "Skip windows version check";
            this.SkipCheckWindowsVersion.UseVisualStyleBackColor = true;
            this.SkipCheckWindowsVersion.CheckedChanged += new System.EventHandler(this.SkipCheckWindowsVersion_CheckedChanged);
            // 
            // CrcSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrcSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.CrcSettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage properties_tab;
        private System.Windows.Forms.TabPage advance_tab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PullSecretSelectButton;
        private System.Windows.Forms.Button BundleSelectButton;
        private System.Windows.Forms.CheckBox enableExperimentalFeatures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pullSecretTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bundleTxtBox;
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
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nameServerTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox disableUpdateCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown memoryNumBox;
        private System.Windows.Forms.NumericUpDown cpusNumBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown diskSizeNumBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox SkipCheckWindowsVersion;
        private System.Windows.Forms.CheckBox SkipCheckRunningAsAdmin;
        private System.Windows.Forms.CheckBox SkipCheckUserInHypervAdminsGroup;
    }
}