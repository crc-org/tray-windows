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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CrcStatus = new System.Windows.Forms.Label();
            this.OpenShiftStatus = new System.Windows.Forms.Label();
            this.DiskUsage = new System.Windows.Forms.Label();
            this.CacheFolderStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodeReady Containers status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CRC status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "OpenShift status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disk Usage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cache Folder:";
            // 
            // CrcStatus
            // 
            this.CrcStatus.AutoSize = true;
            this.CrcStatus.Location = new System.Drawing.Point(147, 64);
            this.CrcStatus.Name = "CrcStatus";
            this.CrcStatus.Size = new System.Drawing.Size(47, 25);
            this.CrcStatus.TabIndex = 5;
            this.CrcStatus.Text = "|||||||";
            // 
            // OpenShiftStatus
            // 
            this.OpenShiftStatus.AutoSize = true;
            this.OpenShiftStatus.Location = new System.Drawing.Point(191, 107);
            this.OpenShiftStatus.Name = "OpenShiftStatus";
            this.OpenShiftStatus.Size = new System.Drawing.Size(52, 25);
            this.OpenShiftStatus.TabIndex = 6;
            this.OpenShiftStatus.Text = "||||||||";
            // 
            // DiskUsage
            // 
            this.DiskUsage.AutoSize = true;
            this.DiskUsage.Location = new System.Drawing.Point(147, 150);
            this.DiskUsage.Name = "DiskUsage";
            this.DiskUsage.Size = new System.Drawing.Size(42, 25);
            this.DiskUsage.TabIndex = 7;
            this.DiskUsage.Text = "||||||";
            // 
            // CacheFolderStatus
            // 
            this.CacheFolderStatus.AutoSize = true;
            this.CacheFolderStatus.Location = new System.Drawing.Point(165, 187);
            this.CacheFolderStatus.Name = "CacheFolderStatus";
            this.CacheFolderStatus.Size = new System.Drawing.Size(47, 25);
            this.CacheFolderStatus.TabIndex = 8;
            this.CacheFolderStatus.Text = "|||||||";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 258);
            this.Controls.Add(this.CacheFolderStatus);
            this.Controls.Add(this.DiskUsage);
            this.Controls.Add(this.OpenShiftStatus);
            this.Controls.Add(this.CrcStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatusForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CrcStatus;
        private System.Windows.Forms.Label OpenShiftStatus;
        private System.Windows.Forms.Label DiskUsage;
        private System.Windows.Forms.Label CacheFolderStatus;
    }
}