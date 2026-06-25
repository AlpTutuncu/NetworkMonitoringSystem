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
            this.dgvPingLog = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblPingKayit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPingLog
            // 
            this.dgvPingLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPingLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPingLog.Location = new System.Drawing.Point(0, 97);
            this.dgvPingLog.Name = "dgvPingLog";
            this.dgvPingLog.ReadOnly = true;
            this.dgvPingLog.RowHeadersWidth = 62;
            this.dgvPingLog.RowTemplate.Height = 28;
            this.dgvPingLog.Size = new System.Drawing.Size(992, 511);
            this.dgvPingLog.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(162, 40);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Ana Sayfaya Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblPingKayit
            // 
            this.lblPingKayit.AutoSize = true;
            this.lblPingKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPingKayit.ForeColor = System.Drawing.Color.Coral;
            this.lblPingKayit.Location = new System.Drawing.Point(398, 38);
            this.lblPingKayit.Name = "lblPingKayit";
            this.lblPingKayit.Size = new System.Drawing.Size(182, 32);
            this.lblPingKayit.TabIndex = 2;
            this.lblPingKayit.Text = "Ping Kayıtları";
            // 
            // PingLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 608);
            this.Controls.Add(this.lblPingKayit);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvPingLog);
            this.Name = "PingLogForm";
            this.Text = "PingLogForm";
            this.Load += new System.EventHandler(this.PingLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPingLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPingLog;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblPingKayit;
    }
}