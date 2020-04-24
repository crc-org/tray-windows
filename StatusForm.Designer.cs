namespace tray_windows
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CodeReady Containers status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "OpenShift status:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disk Usage:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cache Usage:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CrcStatus
            // 
            this.CrcStatus.AutoSize = true;
            this.CrcStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrcStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrcStatus.Location = new System.Drawing.Point(220, 0);
            this.CrcStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CrcStatus.Name = "CrcStatus";
            this.CrcStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CrcStatus.Size = new System.Drawing.Size(278, 23);
            this.CrcStatus.TabIndex = 5;
            this.CrcStatus.Text = "||||||||";
            this.CrcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenShiftStatus
            // 
            this.OpenShiftStatus.AutoSize = true;
            this.OpenShiftStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenShiftStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenShiftStatus.Location = new System.Drawing.Point(220, 23);
            this.OpenShiftStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OpenShiftStatus.Name = "OpenShiftStatus";
            this.OpenShiftStatus.Size = new System.Drawing.Size(278, 23);
            this.OpenShiftStatus.TabIndex = 6;
            this.OpenShiftStatus.Text = "||||||||";
            this.OpenShiftStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiskUsage
            // 
            this.DiskUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiskUsage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskUsage.Location = new System.Drawing.Point(220, 46);
            this.DiskUsage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DiskUsage.Name = "DiskUsage";
            this.DiskUsage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiskUsage.Size = new System.Drawing.Size(278, 23);
            this.DiskUsage.TabIndex = 7;
            this.DiskUsage.Text = "||||||||";
            this.DiskUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CacheUsage
            // 
            this.CacheUsage.AutoSize = true;
            this.CacheUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CacheUsage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheUsage.Location = new System.Drawing.Point(220, 69);
            this.CacheUsage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CacheUsage.Name = "CacheUsage";
            this.CacheUsage.Size = new System.Drawing.Size(278, 23);
            this.CacheUsage.TabIndex = 8;
            this.CacheUsage.Text = "||||||||";
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 119);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cache Folder:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CacheFolder
            // 
            this.CacheFolder.AutoSize = true;
            this.CacheFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CacheFolder.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheFolder.Location = new System.Drawing.Point(220, 92);
            this.CacheFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CacheFolder.Name = "CacheFolder";
            this.CacheFolder.Size = new System.Drawing.Size(278, 27);
            this.CacheFolder.TabIndex = 10;
            this.CacheFolder.Text = "||||||||";
            this.CacheFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 119);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.ShowInTaskbar = false;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}