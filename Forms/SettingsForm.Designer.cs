namespace CRCTray
{
    partial class SettingsForm
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.proxyCABrowseButton = new System.Windows.Forms.Button();
            this.proxyCAFileTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.httpProxyTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.httpsProxyTxtBox = new System.Windows.Forms.TextBox();
            this.noProxyTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useProxyTick = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.consentTelemetryCheckBox = new System.Windows.Forms.CheckBox();
            this.cpusNumBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.memoryNumBox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.diskSizeNumBox = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.advance_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshButton2 = new System.Windows.Forms.Button();
            this.applyButton2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.disableUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.nameServerTxtBox = new System.Windows.Forms.TextBox();
            this.autostartTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SkipCheckWindowsVersion = new System.Windows.Forms.CheckBox();
            this.SkipCheckRunningAsAdmin = new System.Windows.Forms.CheckBox();
            this.SkipCheckUserInHypervAdminsGroup = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileRequester = new System.Windows.Forms.OpenFileDialog();
            this.tabs.SuspendLayout();
            this.properties_tab.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpusNumBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumBox)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeNumBox)).BeginInit();
            this.advance_tab.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AccessibleName = "Settings tab";
            this.tabs.Controls.Add(this.properties_tab);
            this.tabs.Controls.Add(this.advance_tab);
            this.tabs.Location = new System.Drawing.Point(7, 7);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(502, 368);
            this.tabs.TabIndex = 0;
            // 
            // properties_tab
            // 
            this.properties_tab.Controls.Add(this.tableLayoutPanel6);
            this.properties_tab.Controls.Add(this.groupBox2);
            this.properties_tab.Controls.Add(this.groupBox1);
            this.properties_tab.Location = new System.Drawing.Point(4, 22);
            this.properties_tab.Margin = new System.Windows.Forms.Padding(2);
            this.properties_tab.Name = "properties_tab";
            this.properties_tab.Padding = new System.Windows.Forms.Padding(2);
            this.properties_tab.Size = new System.Drawing.Size(494, 342);
            this.properties_tab.TabIndex = 0;
            this.properties_tab.Text = "Properties";
            this.properties_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.refreshButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.applyButton, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(338, 310);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(146, 28);
            this.tableLayoutPanel6.TabIndex = 16;
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleName = "Refresh button";
            this.refreshButton.Location = new System.Drawing.Point(2, 2);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(68, 22);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.AccessibleName = "Apply button";
            this.applyButton.Location = new System.Drawing.Point(75, 2);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(68, 22);
            this.applyButton.TabIndex = 15;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(3, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(486, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proxy";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.proxyCABrowseButton, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.proxyCAFileTxtBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.httpProxyTxtBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.httpsProxyTxtBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.noProxyTxtBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.useProxyTick, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(482, 127);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // proxyCABrowseButton
            // 
            this.proxyCABrowseButton.AccessibleName = "Proxy CA filerequester";
            this.proxyCABrowseButton.Location = new System.Drawing.Point(411, 102);
            this.proxyCABrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.proxyCABrowseButton.Name = "proxyCABrowseButton";
            this.proxyCABrowseButton.Size = new System.Drawing.Size(68, 22);
            this.proxyCABrowseButton.TabIndex = 13;
            this.proxyCABrowseButton.Text = "Select file";
            this.proxyCABrowseButton.UseVisualStyleBackColor = true;
            this.proxyCABrowseButton.Click += new System.EventHandler(this.proxyCABrowseButton_Click);
            // 
            // proxyCAFileTxtBox
            // 
            this.proxyCAFileTxtBox.AccessibleName = "Proxy CA file";
            this.proxyCAFileTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyCAFileTxtBox.Enabled = false;
            this.proxyCAFileTxtBox.Location = new System.Drawing.Point(98, 102);
            this.proxyCAFileTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.proxyCAFileTxtBox.Name = "proxyCAFileTxtBox";
            this.proxyCAFileTxtBox.Size = new System.Drawing.Size(309, 20);
            this.proxyCAFileTxtBox.TabIndex = 12;
            this.proxyCAFileTxtBox.TextChanged += new System.EventHandler(this.proxyCAFileTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "HTTP Proxy";
            // 
            // httpProxyTxtBox
            // 
            this.httpProxyTxtBox.AccessibleName = "HTTP proxy";
            this.httpProxyTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpProxyTxtBox.Enabled = false;
            this.httpProxyTxtBox.Location = new System.Drawing.Point(98, 27);
            this.httpProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.httpProxyTxtBox.Name = "httpProxyTxtBox";
            this.httpProxyTxtBox.Size = new System.Drawing.Size(309, 20);
            this.httpProxyTxtBox.TabIndex = 9;
            this.httpProxyTxtBox.TextChanged += new System.EventHandler(this.httpProxyTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "HTTPS Proxy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proxy CA file";
            // 
            // httpsProxyTxtBox
            // 
            this.httpsProxyTxtBox.AccessibleName = "HTTPS proxy";
            this.httpsProxyTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpsProxyTxtBox.Enabled = false;
            this.httpsProxyTxtBox.Location = new System.Drawing.Point(98, 52);
            this.httpsProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.httpsProxyTxtBox.Name = "httpsProxyTxtBox";
            this.httpsProxyTxtBox.Size = new System.Drawing.Size(309, 20);
            this.httpsProxyTxtBox.TabIndex = 10;
            this.httpsProxyTxtBox.TextChanged += new System.EventHandler(this.httpsProxyTxtBox_TextChanged);
            // 
            // noProxyTxtBox
            // 
            this.noProxyTxtBox.AccessibleName = "No proxy";
            this.noProxyTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noProxyTxtBox.Enabled = false;
            this.noProxyTxtBox.Location = new System.Drawing.Point(98, 77);
            this.noProxyTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.noProxyTxtBox.Name = "noProxyTxtBox";
            this.noProxyTxtBox.Size = new System.Drawing.Size(309, 20);
            this.noProxyTxtBox.TabIndex = 11;
            this.noProxyTxtBox.TextChanged += new System.EventHandler(this.noProxyTxtBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Proxy(s)";
            // 
            // useProxyTick
            // 
            this.useProxyTick.AccessibleName = "Use proxy";
            this.useProxyTick.AutoSize = true;
            this.useProxyTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useProxyTick.Location = new System.Drawing.Point(98, 2);
            this.useProxyTick.Margin = new System.Windows.Forms.Padding(2);
            this.useProxyTick.Name = "useProxyTick";
            this.useProxyTick.Size = new System.Drawing.Size(309, 21);
            this.useProxyTick.TabIndex = 8;
            this.useProxyTick.Text = "Use Proxy";
            this.useProxyTick.UseVisualStyleBackColor = true;
            this.useProxyTick.CheckedChanged += new System.EventHandler(this.useProxy_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(486, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.91701F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.08298F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.consentTelemetryCheckBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cpusNumBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 127);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPUs";
            // 
            // consentTelemetryCheckBox
            // 
            this.consentTelemetryCheckBox.AutoSize = true;
            this.consentTelemetryCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consentTelemetryCheckBox.Location = new System.Drawing.Point(97, 102);
            this.consentTelemetryCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.consentTelemetryCheckBox.Name = "consentTelemetryCheckBox";
            this.consentTelemetryCheckBox.Size = new System.Drawing.Size(383, 23);
            this.consentTelemetryCheckBox.TabIndex = 17;
            this.consentTelemetryCheckBox.Text = "Report telemetry to Red Hat";
            this.consentTelemetryCheckBox.UseVisualStyleBackColor = true;
            this.consentTelemetryCheckBox.CheckedChanged += new System.EventHandler(this.consentTelemetryCheckBox_CheckedChanged);
            // 
            // cpusNumBox
            // 
            this.cpusNumBox.AccessibleName = "vCPUs";
            this.cpusNumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.cpusNumBox.Location = new System.Drawing.Point(97, 2);
            this.cpusNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpusNumBox.Name = "cpusNumBox";
            this.cpusNumBox.Size = new System.Drawing.Size(70, 20);
            this.cpusNumBox.TabIndex = 3;
            this.cpusNumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cpusNumBox.ValueChanged += new System.EventHandler(this.cpusNumBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Memory";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(2, 75);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 25);
            this.label22.TabIndex = 15;
            this.label22.Text = "Disk Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pull secret";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.memoryNumBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(97, 27);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(107, 21);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // memoryNumBox
            // 
            this.memoryNumBox.AccessibleName = "Memory";
            this.memoryNumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.memoryNumBox.Location = new System.Drawing.Point(0, 0);
            this.memoryNumBox.Margin = new System.Windows.Forms.Padding(0);
            this.memoryNumBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.memoryNumBox.Name = "memoryNumBox";
            this.memoryNumBox.Size = new System.Drawing.Size(70, 20);
            this.memoryNumBox.TabIndex = 4;
            this.memoryNumBox.Value = new decimal(new int[] {
            9126,
            0,
            0,
            0});
            this.memoryNumBox.ValueChanged += new System.EventHandler(this.memoryNumBox_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "MB";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.diskSizeNumBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(95, 75);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(110, 25);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // diskSizeNumBox
            // 
            this.diskSizeNumBox.AccessibleName = "Disk size";
            this.diskSizeNumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.diskSizeNumBox.Location = new System.Drawing.Point(2, 2);
            this.diskSizeNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.diskSizeNumBox.Name = "diskSizeNumBox";
            this.diskSizeNumBox.Size = new System.Drawing.Size(71, 20);
            this.diskSizeNumBox.TabIndex = 7;
            this.diskSizeNumBox.ValueChanged += new System.EventHandler(this.diskSizeNumBox_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(77, 0);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(2);
            this.label23.Size = new System.Drawing.Size(26, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "GB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PullSecretChangeButton_Click);
            // 
            // advance_tab
            // 
            this.advance_tab.Controls.Add(this.tableLayoutPanel8);
            this.advance_tab.Controls.Add(this.groupBox4);
            this.advance_tab.Controls.Add(this.groupBox3);
            this.advance_tab.Location = new System.Drawing.Point(4, 22);
            this.advance_tab.Margin = new System.Windows.Forms.Padding(2);
            this.advance_tab.Name = "advance_tab";
            this.advance_tab.Padding = new System.Windows.Forms.Padding(2);
            this.advance_tab.Size = new System.Drawing.Size(494, 342);
            this.advance_tab.TabIndex = 1;
            this.advance_tab.Text = "Advanced";
            this.advance_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.refreshButton2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.applyButton2, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(344, 226);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(146, 28);
            this.tableLayoutPanel8.TabIndex = 24;
            // 
            // refreshButton2
            // 
            this.refreshButton2.AccessibleName = "Refresh button";
            this.refreshButton2.Location = new System.Drawing.Point(2, 2);
            this.refreshButton2.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton2.Name = "refreshButton2";
            this.refreshButton2.Size = new System.Drawing.Size(68, 22);
            this.refreshButton2.TabIndex = 22;
            this.refreshButton2.Text = "Refresh";
            this.refreshButton2.UseVisualStyleBackColor = true;
            this.refreshButton2.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // applyButton2
            // 
            this.applyButton2.AccessibleName = "Apply button";
            this.applyButton2.Location = new System.Drawing.Point(75, 2);
            this.applyButton2.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton2.Name = "applyButton2";
            this.applyButton2.Size = new System.Drawing.Size(68, 22);
            this.applyButton2.TabIndex = 23;
            this.applyButton2.Text = "Apply";
            this.applyButton2.UseVisualStyleBackColor = true;
            this.applyButton2.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Location = new System.Drawing.Point(4, 115);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(486, 94);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.Controls.Add(this.disableUpdateCheckBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.nameServerTxtBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.autostartTrayCheckBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(482, 77);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // disableUpdateCheckBox
            // 
            this.disableUpdateCheckBox.AccessibleName = "Disable update check";
            this.disableUpdateCheckBox.AutoSize = true;
            this.disableUpdateCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.disableUpdateCheckBox.Location = new System.Drawing.Point(98, 2);
            this.disableUpdateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.disableUpdateCheckBox.Name = "disableUpdateCheckBox";
            this.disableUpdateCheckBox.Size = new System.Drawing.Size(130, 22);
            this.disableUpdateCheckBox.TabIndex = 19;
            this.disableUpdateCheckBox.Text = "Disable update check";
            this.disableUpdateCheckBox.UseVisualStyleBackColor = true;
            this.disableUpdateCheckBox.CheckedChanged += new System.EventHandler(this.disableUpdateCheckBox_CheckedChanged);
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
            this.nameServerTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameServerTxtBox.Location = new System.Drawing.Point(98, 54);
            this.nameServerTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameServerTxtBox.Name = "nameServerTxtBox";
            this.nameServerTxtBox.Size = new System.Drawing.Size(123, 20);
            this.nameServerTxtBox.TabIndex = 20;
            this.nameServerTxtBox.TextChanged += new System.EventHandler(this.nameServerTxtBox_TextChanged);
            // 
            // autostartTrayCheckBox
            // 
            this.autostartTrayCheckBox.AutoSize = true;
            this.autostartTrayCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.autostartTrayCheckBox.Location = new System.Drawing.Point(98, 28);
            this.autostartTrayCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.autostartTrayCheckBox.Name = "autostartTrayCheckBox";
            this.autostartTrayCheckBox.Size = new System.Drawing.Size(151, 22);
            this.autostartTrayCheckBox.TabIndex = 21;
            this.autostartTrayCheckBox.Text = "Automatically start on login";
            this.autostartTrayCheckBox.UseVisualStyleBackColor = true;
            this.autostartTrayCheckBox.CheckedChanged += new System.EventHandler(this.autostartTrayCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(2, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nameserver";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(486, 107);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 78);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // SkipCheckWindowsVersion
            // 
            this.SkipCheckWindowsVersion.AccessibleName = "Skip Windows version check";
            this.SkipCheckWindowsVersion.AutoSize = true;
            this.SkipCheckWindowsVersion.Location = new System.Drawing.Point(3, 55);
            this.SkipCheckWindowsVersion.Name = "SkipCheckWindowsVersion";
            this.SkipCheckWindowsVersion.Size = new System.Drawing.Size(161, 17);
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
            this.SkipCheckRunningAsAdmin.Location = new System.Drawing.Point(3, 29);
            this.SkipCheckRunningAsAdmin.Name = "SkipCheckRunningAsAdmin";
            this.SkipCheckRunningAsAdmin.Size = new System.Drawing.Size(201, 17);
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
            this.SkipCheckUserInHypervAdminsGroup.Location = new System.Drawing.Point(3, 3);
            this.SkipCheckUserInHypervAdminsGroup.Name = "SkipCheckUserInHypervAdminsGroup";
            this.SkipCheckUserInHypervAdminsGroup.Size = new System.Drawing.Size(215, 17);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(516, 381);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.CrcSettingsForm_Load);
            this.tabs.ResumeLayout(false);
            this.properties_tab.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpusNumBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumBox)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeNumBox)).EndInit();
            this.advance_tab.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}