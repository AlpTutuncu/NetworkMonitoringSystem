namespace NetworkMonitoringWF.Forms
{
    partial class PingLogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblPingKayit = new System.Windows.Forms.Label();
            this.dgvPingLog = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCihazIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGeri.Location = new System.Drawing.Point(994, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(138, 52);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "↩   Ana Sayfa";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblPingKayit
            // 
            this.lblPingKayit.AutoSize = true;
            this.lblPingKayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPingKayit.ForeColor = System.Drawing.Color.Coral;
            this.lblPingKayit.Location = new System.Drawing.Point(101, 23);
            this.lblPingKayit.Name = "lblPingKayit";
            this.lblPingKayit.Size = new System.Drawing.Size(202, 32);
            this.lblPingKayit.TabIndex = 2;
            this.lblPingKayit.Text = "PING KAYITLARI";
            // 
            // dgvPingLog
            // 
            this.dgvPingLog.AllowUserToResizeRows = false;
            this.dgvPingLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPingLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPingLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPingLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPingLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPingLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPingLog.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPingLog.EnableHeadersVisualStyles = false;
            this.dgvPingLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPingLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPingLog.Location = new System.Drawing.Point(12, 85);
            this.dgvPingLog.Name = "dgvPingLog";
            this.dgvPingLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPingLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPingLog.RowHeadersVisible = false;
            this.dgvPingLog.RowHeadersWidth = 62;
            this.dgvPingLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPingLog.RowTemplate.Height = 28;
            this.dgvPingLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPingLog.Size = new System.Drawing.Size(1119, 603);
            this.dgvPingLog.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCihazIcon);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.lblPingKayit);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 80);
            this.panel1.TabIndex = 4;
            // 
            // lblCihazIcon
            // 
            this.lblCihazIcon.AutoSize = true;
            this.lblCihazIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazIcon.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazIcon.Location = new System.Drawing.Point(17, 10);
            this.lblCihazIcon.Name = "lblCihazIcon";
            this.lblCihazIcon.Size = new System.Drawing.Size(78, 54);
            this.lblCihazIcon.TabIndex = 12;
            this.lblCihazIcon.Text = "📡";
            // 
            // PingLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPingLog);
            this.Name = "PingLogForm";
            this.Text = "PingLogForm";
            this.Load += new System.EventHandler(this.PingLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblPingKayit;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvPingLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCihazIcon;
    }
}