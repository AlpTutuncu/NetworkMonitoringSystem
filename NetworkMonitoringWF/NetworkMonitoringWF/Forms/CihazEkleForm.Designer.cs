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
            this.lblCihazEkle = new System.Windows.Forms.Label();
            this.cmbVlan = new System.Windows.Forms.ComboBox();
            this.lblVLAN = new System.Windows.Forms.Label();
            this.txtCihazAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtIPAdresi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtCihazTipi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtKonum = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(66, 322);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(73, 25);
            this.lblKonum.TabIndex = 19;
            this.lblKonum.Text = "Konum:";
            // 
            // lblCihazTipi
            // 
            this.lblCihazTipi.AutoSize = true;
            this.lblCihazTipi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazTipi.Location = new System.Drawing.Point(48, 256);
            this.lblCihazTipi.Name = "lblCihazTipi";
            this.lblCihazTipi.Size = new System.Drawing.Size(91, 25);
            this.lblCihazTipi.TabIndex = 18;
            this.lblCihazTipi.Text = "Cihaz Tipi:";
            // 
            // lblIPAdresi
            // 
            this.lblIPAdresi.AutoSize = true;
            this.lblIPAdresi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIPAdresi.Location = new System.Drawing.Point(53, 191);
            this.lblIPAdresi.Name = "lblIPAdresi";
            this.lblIPAdresi.Size = new System.Drawing.Size(86, 25);
            this.lblIPAdresi.TabIndex = 17;
            this.lblIPAdresi.Text = "IP Adresi:";
            // 
            // lblCihazAdi
            // 
            this.lblCihazAdi.AutoSize = true;
            this.lblCihazAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazAdi.Location = new System.Drawing.Point(49, 126);
            this.lblCihazAdi.Name = "lblCihazAdi";
            this.lblCihazAdi.Size = new System.Drawing.Size(90, 25);
            this.lblCihazAdi.TabIndex = 16;
            this.lblCihazAdi.Text = "Cihaz Adı:";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(445, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 48);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(237, 429);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(190, 39);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblCihazEkle
            // 
            this.lblCihazEkle.AutoSize = true;
            this.lblCihazEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblCihazEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCihazEkle.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazEkle.Location = new System.Drawing.Point(90, 18);
            this.lblCihazEkle.Name = "lblCihazEkle";
            this.lblCihazEkle.Size = new System.Drawing.Size(148, 32);
            this.lblCihazEkle.TabIndex = 20;
            this.lblCihazEkle.Text = "CİHAZ EKLE";
            // 
            // cmbVlan
            // 
            this.cmbVlan.FormattingEnabled = true;
            this.cmbVlan.Location = new System.Drawing.Point(169, 379);
            this.cmbVlan.Name = "cmbVlan";
            this.cmbVlan.Size = new System.Drawing.Size(321, 28);
            this.cmbVlan.TabIndex = 21;
            // 
            // lblVLAN
            // 
            this.lblVLAN.AutoSize = true;
            this.lblVLAN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVLAN.Location = new System.Drawing.Point(78, 379);
            this.lblVLAN.Name = "lblVLAN";
            this.lblVLAN.Size = new System.Drawing.Size(61, 25);
            this.lblVLAN.TabIndex = 22;
            this.lblVLAN.Text = "VLAN:";
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
            this.txtCihazAdi.Location = new System.Drawing.Point(169, 115);
            this.txtCihazAdi.MaxLength = 32767;
            this.txtCihazAdi.Multiline = false;
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.PasswordChar = '\0';
            this.txtCihazAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCihazAdi.SelectedText = "";
            this.txtCihazAdi.SelectionLength = 0;
            this.txtCihazAdi.SelectionStart = 0;
            this.txtCihazAdi.Size = new System.Drawing.Size(321, 48);
            this.txtCihazAdi.TabIndex = 23;
            this.txtCihazAdi.TabStop = false;
            this.txtCihazAdi.UseSystemPasswordChar = false;
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
            this.txtIPAdresi.Location = new System.Drawing.Point(169, 181);
            this.txtIPAdresi.MaxLength = 32767;
            this.txtIPAdresi.Multiline = false;
            this.txtIPAdresi.Name = "txtIPAdresi";
            this.txtIPAdresi.PasswordChar = '\0';
            this.txtIPAdresi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIPAdresi.SelectedText = "";
            this.txtIPAdresi.SelectionLength = 0;
            this.txtIPAdresi.SelectionStart = 0;
            this.txtIPAdresi.Size = new System.Drawing.Size(321, 48);
            this.txtIPAdresi.TabIndex = 24;
            this.txtIPAdresi.TabStop = false;
            this.txtIPAdresi.UseSystemPasswordChar = false;
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
            this.txtCihazTipi.Location = new System.Drawing.Point(169, 246);
            this.txtCihazTipi.MaxLength = 32767;
            this.txtCihazTipi.Multiline = false;
            this.txtCihazTipi.Name = "txtCihazTipi";
            this.txtCihazTipi.PasswordChar = '\0';
            this.txtCihazTipi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCihazTipi.SelectedText = "";
            this.txtCihazTipi.SelectionLength = 0;
            this.txtCihazTipi.SelectionStart = 0;
            this.txtCihazTipi.Size = new System.Drawing.Size(321, 48);
            this.txtCihazTipi.TabIndex = 25;
            this.txtCihazTipi.TabStop = false;
            this.txtCihazTipi.UseSystemPasswordChar = false;
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
            this.txtKonum.Location = new System.Drawing.Point(169, 313);
            this.txtKonum.MaxLength = 32767;
            this.txtKonum.Multiline = false;
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.PasswordChar = '\0';
            this.txtKonum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKonum.SelectedText = "";
            this.txtKonum.SelectionLength = 0;
            this.txtKonum.SelectionStart = 0;
            this.txtKonum.Size = new System.Drawing.Size(321, 48);
            this.txtKonum.TabIndex = 26;
            this.txtKonum.TabStop = false;
            this.txtKonum.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCihazEkle);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 73);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "➕";
            // 
            // CihazEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtCihazTipi);
            this.Controls.Add(this.txtIPAdresi);
            this.Controls.Add(this.txtCihazAdi);
            this.Controls.Add(this.lblVLAN);
            this.Controls.Add(this.cmbVlan);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblCihazTipi);
            this.Controls.Add(this.lblIPAdresi);
            this.Controls.Add(this.lblCihazAdi);
            this.Controls.Add(this.btnKaydet);
            this.Name = "CihazEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CihazEkleForm";
            this.Load += new System.EventHandler(this.CihazEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblCihazEkle;
        private System.Windows.Forms.ComboBox cmbVlan;
        private System.Windows.Forms.Label lblVLAN;
        private ReaLTaiizor.Controls.HopeTextBox txtCihazAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtIPAdresi;
        private ReaLTaiizor.Controls.HopeTextBox txtCihazTipi;
        private ReaLTaiizor.Controls.HopeTextBox txtKonum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}