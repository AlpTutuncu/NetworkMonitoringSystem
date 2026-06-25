namespace NetworkMonitoringWF
{
    partial class CihazEkleForm
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
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblCihazTipi = new System.Windows.Forms.Label();
            this.lblIPAdresi = new System.Windows.Forms.Label();
            this.lblCihazAdi = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.txtCihazTipi = new System.Windows.Forms.TextBox();
            this.txtIPAdresi = new System.Windows.Forms.TextBox();
            this.txtCihazAdi = new System.Windows.Forms.TextBox();
            this.lblCihazEkle = new System.Windows.Forms.Label();
            this.cmbVlan = new System.Windows.Forms.ComboBox();
            this.lblVLAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(78, 273);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(63, 20);
            this.lblKonum.TabIndex = 19;
            this.lblKonum.Text = "Konum:";
            // 
            // lblCihazTipi
            // 
            this.lblCihazTipi.AutoSize = true;
            this.lblCihazTipi.Location = new System.Drawing.Point(78, 221);
            this.lblCihazTipi.Name = "lblCihazTipi";
            this.lblCihazTipi.Size = new System.Drawing.Size(81, 20);
            this.lblCihazTipi.TabIndex = 18;
            this.lblCihazTipi.Text = "Cihaz Tipi:";
            // 
            // lblIPAdresi
            // 
            this.lblIPAdresi.AutoSize = true;
            this.lblIPAdresi.Location = new System.Drawing.Point(78, 167);
            this.lblIPAdresi.Name = "lblIPAdresi";
            this.lblIPAdresi.Size = new System.Drawing.Size(77, 20);
            this.lblIPAdresi.TabIndex = 17;
            this.lblIPAdresi.Text = "IP Adresi:";
            // 
            // lblCihazAdi
            // 
            this.lblCihazAdi.AutoSize = true;
            this.lblCihazAdi.Location = new System.Drawing.Point(78, 113);
            this.lblCihazAdi.Name = "lblCihazAdi";
            this.lblCihazAdi.Size = new System.Drawing.Size(80, 20);
            this.lblCihazAdi.TabIndex = 16;
            this.lblCihazAdi.Text = "Cihaz Adı:";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(86, 33);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(419, 379);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 39);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(239, 270);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(273, 26);
            this.txtKonum.TabIndex = 13;
            // 
            // txtCihazTipi
            // 
            this.txtCihazTipi.Location = new System.Drawing.Point(239, 218);
            this.txtCihazTipi.Name = "txtCihazTipi";
            this.txtCihazTipi.Size = new System.Drawing.Size(273, 26);
            this.txtCihazTipi.TabIndex = 12;
            // 
            // txtIPAdresi
            // 
            this.txtIPAdresi.Location = new System.Drawing.Point(239, 164);
            this.txtIPAdresi.Name = "txtIPAdresi";
            this.txtIPAdresi.Size = new System.Drawing.Size(273, 26);
            this.txtIPAdresi.TabIndex = 11;
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.Location = new System.Drawing.Point(239, 110);
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.Size = new System.Drawing.Size(273, 26);
            this.txtCihazAdi.TabIndex = 10;
            // 
            // lblCihazEkle
            // 
            this.lblCihazEkle.AutoSize = true;
            this.lblCihazEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblCihazEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazEkle.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazEkle.Location = new System.Drawing.Point(233, 40);
            this.lblCihazEkle.Name = "lblCihazEkle";
            this.lblCihazEkle.Size = new System.Drawing.Size(150, 32);
            this.lblCihazEkle.TabIndex = 20;
            this.lblCihazEkle.Text = "Cihaz Ekle";
            // 
            // cmbVlan
            // 
            this.cmbVlan.FormattingEnabled = true;
            this.cmbVlan.Location = new System.Drawing.Point(239, 328);
            this.cmbVlan.Name = "cmbVlan";
            this.cmbVlan.Size = new System.Drawing.Size(273, 28);
            this.cmbVlan.TabIndex = 21;
            // 
            // lblVLAN
            // 
            this.lblVLAN.AutoSize = true;
            this.lblVLAN.Location = new System.Drawing.Point(78, 336);
            this.lblVLAN.Name = "lblVLAN";
            this.lblVLAN.Size = new System.Drawing.Size(55, 20);
            this.lblVLAN.TabIndex = 22;
            this.lblVLAN.Text = "VLAN:";
            // 
            // CihazEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 446);
            this.Controls.Add(this.lblVLAN);
            this.Controls.Add(this.cmbVlan);
            this.Controls.Add(this.lblCihazEkle);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblCihazTipi);
            this.Controls.Add(this.lblIPAdresi);
            this.Controls.Add(this.lblCihazAdi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtCihazTipi);
            this.Controls.Add(this.txtIPAdresi);
            this.Controls.Add(this.txtCihazAdi);
            this.Name = "CihazEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CihazEkleForm";
            this.Load += new System.EventHandler(this.CihazEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblCihazTipi;
        private System.Windows.Forms.Label lblIPAdresi;
        private System.Windows.Forms.Label lblCihazAdi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.TextBox txtCihazTipi;
        private System.Windows.Forms.TextBox txtIPAdresi;
        private System.Windows.Forms.TextBox txtCihazAdi;
        private System.Windows.Forms.Label lblCihazEkle;
        private System.Windows.Forms.ComboBox cmbVlan;
        private System.Windows.Forms.Label lblVLAN;
    }
}