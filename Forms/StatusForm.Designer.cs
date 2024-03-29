﻿namespace CRCTray
{
    partial class StatusForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CrcStatus = new System.Windows.Forms.Label();
            this.OpenShiftStatus = new System.Windows.Forms.Label();
            this.DiskUsage = new System.Windows.Forms.Label();
            this.CacheUsage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CacheFolder = new System.Windows.Forms.Label();
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CodeReady Containers Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "OpenShift Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disk Usage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cache Usage";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CrcStatus
            // 
            this.CrcStatus.AccessibleDescription = "Status of CodeReady Containers";
            this.CrcStatus.AccessibleName = "CRC Status";
            this.CrcStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.CrcStatus.AutoSize = true;
            this.CrcStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrcStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrcStatus.Location = new System.Drawing.Point(207, 0);
            this.CrcStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CrcStatus.Name = "CrcStatus";
            this.CrcStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CrcStatus.Size = new System.Drawing.Size(263, 19);
            this.CrcStatus.TabIndex = 1;
            this.CrcStatus.Text = "Unknown";
            this.CrcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenShiftStatus
            // 
            this.OpenShiftStatus.AccessibleDescription = "Status of OpenShift Container Platform";
            this.OpenShiftStatus.AccessibleName = "OCP Status";
            this.OpenShiftStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.OpenShiftStatus.AutoSize = true;
            this.OpenShiftStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenShiftStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenShiftStatus.Location = new System.Drawing.Point(207, 19);
            this.OpenShiftStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OpenShiftStatus.Name = "OpenShiftStatus";
            this.OpenShiftStatus.Size = new System.Drawing.Size(263, 19);
            this.OpenShiftStatus.TabIndex = 2;
            this.OpenShiftStatus.Text = "Unknown";
            this.OpenShiftStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiskUsage
            // 
            this.DiskUsage.AccessibleDescription = "Disk space used inside the VM";
            this.DiskUsage.AccessibleName = "Disk usage";
            this.DiskUsage.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.DiskUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiskUsage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskUsage.Location = new System.Drawing.Point(207, 38);
            this.DiskUsage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DiskUsage.Name = "DiskUsage";
            this.DiskUsage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiskUsage.Size = new System.Drawing.Size(263, 19);
            this.DiskUsage.TabIndex = 3;
            this.DiskUsage.Text = "Unknown";
            this.DiskUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CacheUsage
            // 
            this.CacheUsage.AccessibleDescription = "Disk space usage by the cache on the host";
            this.CacheUsage.AccessibleName = "Cache usage";
            this.CacheUsage.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.CacheUsage.AutoSize = true;
            this.CacheUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CacheUsage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheUsage.Location = new System.Drawing.Point(207, 57);
            this.CacheUsage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CacheUsage.Name = "CacheUsage";
            this.CacheUsage.Size = new System.Drawing.Size(263, 19);
            this.CacheUsage.TabIndex = 4;
            this.CacheUsage.Text = "Unknown";
            this.CacheUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34127F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CacheFolder, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CacheUsage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DiskUsage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OpenShiftStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CrcStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 95);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cache Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CacheFolder
            // 
            this.CacheFolder.AccessibleDescription = "Location of the cache on the host";
            this.CacheFolder.AccessibleName = "Cache folder";
            this.CacheFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.CacheFolder.AutoSize = true;
            this.CacheFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CacheFolder.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheFolder.Location = new System.Drawing.Point(207, 76);
            this.CacheFolder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CacheFolder.Name = "CacheFolder";
            this.CacheFolder.Size = new System.Drawing.Size(263, 19);
            this.CacheFolder.TabIndex = 5;
            this.CacheFolder.Text = "Unknown";
            this.CacheFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logsTextBox
            // 
            this.logsTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logsTextBox.Location = new System.Drawing.Point(8, 122);
            this.logsTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 3);
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logsTextBox.Size = new System.Drawing.Size(461, 214);
            this.logsTextBox.TabIndex = 10;
            this.logsTextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logs:";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailed Status";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CrcStatus;
        private System.Windows.Forms.Label OpenShiftStatus;
        private System.Windows.Forms.Label DiskUsage;
        private System.Windows.Forms.Label CacheUsage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CacheFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logsTextBox;
        private System.Windows.Forms.Label label6;
    }
}