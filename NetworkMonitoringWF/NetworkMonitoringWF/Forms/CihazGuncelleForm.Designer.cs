namespace NetworkMonitoringWF
{
    partial class CihazGuncelleForm
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
            this.txtCihazAdi = new System.Windows.Forms.TextBox();
            this.txtIPAdresi = new System.Windows.Forms.TextBox();
            this.txtCihazTipi = new System.Windows.Forms.TextBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblCihazAdi = new System.Windows.Forms.Label();
            this.lblIPAdresi = new System.Windows.Forms.Label();
            this.lblCihazTipi = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblCihazGuncelle = new System.Windows.Forms.Label();
            this.lblVLAN = new System.Windows.Forms.Label();
            this.cmbVlan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.Location = new System.Drawing.Point(244, 112);
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.Size = new System.Drawing.Size(273, 26);
            this.txtCihazAdi.TabIndex = 0;
            // 
            // txtIPAdresi
            // 
            this.txtIPAdresi.Location = new System.Drawing.Point(244, 166);
            this.txtIPAdresi.Name = "txtIPAdresi";
            this.txtIPAdresi.Size = new System.Drawing.Size(273, 26);
            this.txtIPAdresi.TabIndex = 1;
            // 
            // txtCihazTipi
            // 
            this.txtCihazTipi.Location = new System.Drawing.Point(244, 220);
            this.txtCihazTipi.Name = "txtCihazTipi";
            this.txtCihazTipi.Size = new System.Drawing.Size(273, 26);
            this.txtCihazTipi.TabIndex = 2;
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(244, 272);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(273, 26);
            this.txtKonum.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(424, 381);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 39);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(86, 33);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblCihazAdi
            // 
            this.lblCihazAdi.AutoSize = true;
            this.lblCihazAdi.Location = new System.Drawing.Point(83, 115);
            this.lblCihazAdi.Name = "lblCihazAdi";
            this.lblCihazAdi.Size = new System.Drawing.Size(80, 20);
            this.lblCihazAdi.TabIndex = 6;
            this.lblCihazAdi.Text = "Cihaz Adı:";
            // 
            // lblIPAdresi
            // 
            this.lblIPAdresi.AutoSize = true;
            this.lblIPAdresi.Location = new System.Drawing.Point(83, 169);
            this.lblIPAdresi.Name = "lblIPAdresi";
            this.lblIPAdresi.Size = new System.Drawing.Size(77, 20);
            this.lblIPAdresi.TabIndex = 7;
            this.lblIPAdresi.Text = "IP Adresi:";
            // 
            // lblCihazTipi
            // 
            this.lblCihazTipi.AutoSize = true;
            this.lblCihazTipi.Location = new System.Drawing.Point(83, 223);
            this.lblCihazTipi.Name = "lblCihazTipi";
            this.lblCihazTipi.Size = new System.Drawing.Size(81, 20);
            this.lblCihazTipi.TabIndex = 8;
            this.lblCihazTipi.Text = "Cihaz Tipi:";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(83, 275);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(63, 20);
            this.lblKonum.TabIndex = 9;
            this.lblKonum.Text = "Konum:";
            // 
            // lblCihazGuncelle
            // 
            this.lblCihazGuncelle.AutoSize = true;
            this.lblCihazGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.lblCihazGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazGuncelle.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazGuncelle.Location = new System.Drawing.Point(207, 50);
            this.lblCihazGuncelle.Name = "lblCihazGuncelle";
            this.lblCihazGuncelle.Size = new System.Drawing.Size(208, 32);
            this.lblCihazGuncelle.TabIndex = 21;
            this.lblCihazGuncelle.Text = "Cihaz Güncelle";
            // 
            // lblVLAN
            // 
            this.lblVLAN.AutoSize = true;
            this.lblVLAN.Location = new System.Drawing.Point(83, 337);
            this.lblVLAN.Name = "lblVLAN";
            this.lblVLAN.Size = new System.Drawing.Size(55, 20);
            this.lblVLAN.TabIndex = 24;
            this.lblVLAN.Text = "VLAN:";
            // 
            // cmbVlan
            // 
            this.cmbVlan.FormattingEnabled = true;
            this.cmbVlan.Location = new System.Drawing.Point(244, 329);
            this.cmbVlan.Name = "cmbVlan";
            this.cmbVlan.Size = new System.Drawing.Size(273, 28);
            this.cmbVlan.TabIndex = 23;
            // 
            // CihazGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 457);
            this.Controls.Add(this.lblVLAN);
            this.Controls.Add(this.cmbVlan);
            this.Controls.Add(this.lblCihazGuncelle);
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
            this.Name = "CihazGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CihazGuncelleForm";
            this.Load += new System.EventHandler(this.CihazGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCihazAdi;
        private System.Windows.Forms.TextBox txtIPAdresi;
        private System.Windows.Forms.TextBox txtCihazTipi;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblCihazAdi;
        private System.Windows.Forms.Label lblIPAdresi;
        private System.Windows.Forms.Label lblCihazTipi;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblCihazGuncelle;
        private System.Windows.Forms.Label lblVLAN;
        private System.Windows.Forms.ComboBox cmbVlan;
    }
}