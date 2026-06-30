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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtKonum = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtCihazTipi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtIPAdresi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtCihazAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVlan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblCihazGuncelle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCihazGuncelle);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 75);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "✏️";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(450, 14);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 48);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtKonum
            // 
            this.txtKonum.BackColor = System.Drawing.Color.White;
            this.txtKonum.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtKonum.BorderColorA = System.Drawing.Color.Coral;
            this.txtKonum.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtKonum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKonum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtKonum.Hint = "";
            this.txtKonum.Location = new System.Drawing.Point(166, 307);
            this.txtKonum.MaxLength = 32767;
            this.txtKonum.Multiline = false;
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.PasswordChar = '\0';
            this.txtKonum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKonum.SelectedText = "";
            this.txtKonum.SelectionLength = 0;
            this.txtKonum.SelectionStart = 0;
            this.txtKonum.Size = new System.Drawing.Size(322, 48);
            this.txtKonum.TabIndex = 38;
            this.txtKonum.TabStop = false;
            this.txtKonum.UseSystemPasswordChar = false;
            // 
            // txtCihazTipi
            // 
            this.txtCihazTipi.BackColor = System.Drawing.Color.White;
            this.txtCihazTipi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtCihazTipi.BorderColorA = System.Drawing.Color.Coral;
            this.txtCihazTipi.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtCihazTipi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCihazTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtCihazTipi.Hint = "";
            this.txtCihazTipi.Location = new System.Drawing.Point(166, 240);
            this.txtCihazTipi.MaxLength = 32767;
            this.txtCihazTipi.Multiline = false;
            this.txtCihazTipi.Name = "txtCihazTipi";
            this.txtCihazTipi.PasswordChar = '\0';
            this.txtCihazTipi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCihazTipi.SelectedText = "";
            this.txtCihazTipi.SelectionLength = 0;
            this.txtCihazTipi.SelectionStart = 0;
            this.txtCihazTipi.Size = new System.Drawing.Size(322, 48);
            this.txtCihazTipi.TabIndex = 37;
            this.txtCihazTipi.TabStop = false;
            this.txtCihazTipi.UseSystemPasswordChar = false;
            // 
            // txtIPAdresi
            // 
            this.txtIPAdresi.BackColor = System.Drawing.Color.White;
            this.txtIPAdresi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtIPAdresi.BorderColorA = System.Drawing.Color.Coral;
            this.txtIPAdresi.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtIPAdresi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIPAdresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtIPAdresi.Hint = "";
            this.txtIPAdresi.Location = new System.Drawing.Point(166, 175);
            this.txtIPAdresi.MaxLength = 32767;
            this.txtIPAdresi.Multiline = false;
            this.txtIPAdresi.Name = "txtIPAdresi";
            this.txtIPAdresi.PasswordChar = '\0';
            this.txtIPAdresi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIPAdresi.SelectedText = "";
            this.txtIPAdresi.SelectionLength = 0;
            this.txtIPAdresi.SelectionStart = 0;
            this.txtIPAdresi.Size = new System.Drawing.Size(322, 48);
            this.txtIPAdresi.TabIndex = 36;
            this.txtIPAdresi.TabStop = false;
            this.txtIPAdresi.UseSystemPasswordChar = false;
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.BackColor = System.Drawing.Color.White;
            this.txtCihazAdi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtCihazAdi.BorderColorA = System.Drawing.Color.Coral;
            this.txtCihazAdi.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtCihazAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCihazAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtCihazAdi.Hint = "";
            this.txtCihazAdi.Location = new System.Drawing.Point(166, 109);
            this.txtCihazAdi.MaxLength = 32767;
            this.txtCihazAdi.Multiline = false;
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.PasswordChar = '\0';
            this.txtCihazAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCihazAdi.SelectedText = "";
            this.txtCihazAdi.SelectionLength = 0;
            this.txtCihazAdi.SelectionStart = 0;
            this.txtCihazAdi.Size = new System.Drawing.Size(322, 48);
            this.txtCihazAdi.TabIndex = 35;
            this.txtCihazAdi.TabStop = false;
            this.txtCihazAdi.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "VLAN:";
            // 
            // cmbVlan
            // 
            this.cmbVlan.FormattingEnabled = true;
            this.cmbVlan.Location = new System.Drawing.Point(166, 373);
            this.cmbVlan.Name = "cmbVlan";
            this.cmbVlan.Size = new System.Drawing.Size(322, 28);
            this.cmbVlan.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Konum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cihaz Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "IP Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cihaz Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(229, 428);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(190, 39);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblCihazGuncelle
            // 
            this.lblCihazGuncelle.AutoSize = true;
            this.lblCihazGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.lblCihazGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCihazGuncelle.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazGuncelle.Location = new System.Drawing.Point(91, 21);
            this.lblCihazGuncelle.Name = "lblCihazGuncelle";
            this.lblCihazGuncelle.Size = new System.Drawing.Size(212, 32);
            this.lblCihazGuncelle.TabIndex = 20;
            this.lblCihazGuncelle.Text = "CİHAZ GÜNCELLE";
            // 
            // CihazGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtCihazTipi);
            this.Controls.Add(this.txtIPAdresi);
            this.Controls.Add(this.txtCihazAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKaydet);
            this.Name = "CihazGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CihazGuncelleForm";
            this.Load += new System.EventHandler(this.CihazGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCihazGuncelle;
        private System.Windows.Forms.Button btnIptal;
        private ReaLTaiizor.Controls.HopeTextBox txtKonum;
        private ReaLTaiizor.Controls.HopeTextBox txtCihazTipi;
        private ReaLTaiizor.Controls.HopeTextBox txtIPAdresi;
        private ReaLTaiizor.Controls.HopeTextBox txtCihazAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
    }
}