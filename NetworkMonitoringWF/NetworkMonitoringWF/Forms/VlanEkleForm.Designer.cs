namespace NetworkMonitoringWF.Forms
{
    partial class VlanEkleForm
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
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.pnlRenk = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblVlanAdi = new System.Windows.Forms.Label();
            this.lblVlanNo = new System.Windows.Forms.Label();
            this.lblVlanEkle = new ReaLTaiizor.Controls.MoonLabel();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtVlanNo = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtVlanAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtSubnet = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtGateway = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtAciklama = new ReaLTaiizor.Controls.HopeTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(188, 356);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(259, 28);
            this.cmbKonum.TabIndex = 5;
            // 
            // pnlRenk
            // 
            this.pnlRenk.Location = new System.Drawing.Point(188, 468);
            this.pnlRenk.Name = "pnlRenk";
            this.pnlRenk.Size = new System.Drawing.Size(46, 37);
            this.pnlRenk.TabIndex = 6;
            this.pnlRenk.Click += new System.EventHandler(this.pnlRenk_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(216, 537);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(197, 42);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(409, 13);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(116, 51);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGateway.Location = new System.Drawing.Point(71, 301);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(83, 25);
            this.lblGateway.TabIndex = 12;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(81, 355);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(73, 25);
            this.lblKonum.TabIndex = 11;
            this.lblKonum.Text = "Konum:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(67, 408);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(87, 25);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubnet.Location = new System.Drawing.Point(82, 242);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(72, 25);
            this.lblSubnet.TabIndex = 9;
            this.lblSubnet.Text = "Subnet:";
            // 
            // lblVlanAdi
            // 
            this.lblVlanAdi.AutoSize = true;
            this.lblVlanAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanAdi.Location = new System.Drawing.Point(61, 179);
            this.lblVlanAdi.Name = "lblVlanAdi";
            this.lblVlanAdi.Size = new System.Drawing.Size(93, 25);
            this.lblVlanAdi.TabIndex = 8;
            this.lblVlanAdi.Text = "VLAN Adı:";
            // 
            // lblVlanNo
            // 
            this.lblVlanNo.AutoSize = true;
            this.lblVlanNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanNo.Location = new System.Drawing.Point(64, 118);
            this.lblVlanNo.Name = "lblVlanNo";
            this.lblVlanNo.Size = new System.Drawing.Size(90, 25);
            this.lblVlanNo.TabIndex = 7;
            this.lblVlanNo.Text = "VLAN No:";
            // 
            // lblVlanEkle
            // 
            this.lblVlanEkle.AutoSize = true;
            this.lblVlanEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblVlanEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVlanEkle.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanEkle.Location = new System.Drawing.Point(76, 22);
            this.lblVlanEkle.Name = "lblVlanEkle";
            this.lblVlanEkle.Size = new System.Drawing.Size(140, 32);
            this.lblVlanEkle.TabIndex = 13;
            this.lblVlanEkle.Text = "VLAN EKLE";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(48, 471);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(106, 25);
            this.lblRenk.TabIndex = 30;
            this.lblRenk.Text = "Renk Etiketi:";
            // 
            // txtVlanNo
            // 
            this.txtVlanNo.BackColor = System.Drawing.Color.White;
            this.txtVlanNo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtVlanNo.BorderColorA = System.Drawing.Color.Coral;
            this.txtVlanNo.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtVlanNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVlanNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtVlanNo.Hint = "";
            this.txtVlanNo.Location = new System.Drawing.Point(188, 108);
            this.txtVlanNo.MaxLength = 32767;
            this.txtVlanNo.Multiline = false;
            this.txtVlanNo.Name = "txtVlanNo";
            this.txtVlanNo.PasswordChar = '\0';
            this.txtVlanNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVlanNo.SelectedText = "";
            this.txtVlanNo.SelectionLength = 0;
            this.txtVlanNo.SelectionStart = 0;
            this.txtVlanNo.Size = new System.Drawing.Size(259, 48);
            this.txtVlanNo.TabIndex = 32;
            this.txtVlanNo.TabStop = false;
            this.txtVlanNo.UseSystemPasswordChar = false;
            // 
            // txtVlanAdi
            // 
            this.txtVlanAdi.BackColor = System.Drawing.Color.White;
            this.txtVlanAdi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtVlanAdi.BorderColorA = System.Drawing.Color.Coral;
            this.txtVlanAdi.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtVlanAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVlanAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtVlanAdi.Hint = "";
            this.txtVlanAdi.Location = new System.Drawing.Point(188, 170);
            this.txtVlanAdi.MaxLength = 32767;
            this.txtVlanAdi.Multiline = false;
            this.txtVlanAdi.Name = "txtVlanAdi";
            this.txtVlanAdi.PasswordChar = '\0';
            this.txtVlanAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVlanAdi.SelectedText = "";
            this.txtVlanAdi.SelectionLength = 0;
            this.txtVlanAdi.SelectionStart = 0;
            this.txtVlanAdi.Size = new System.Drawing.Size(259, 48);
            this.txtVlanAdi.TabIndex = 33;
            this.txtVlanAdi.TabStop = false;
            this.txtVlanAdi.UseSystemPasswordChar = false;
            // 
            // txtSubnet
            // 
            this.txtSubnet.BackColor = System.Drawing.Color.White;
            this.txtSubnet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSubnet.BorderColorA = System.Drawing.Color.Coral;
            this.txtSubnet.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtSubnet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSubnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSubnet.Hint = "";
            this.txtSubnet.Location = new System.Drawing.Point(188, 230);
            this.txtSubnet.MaxLength = 32767;
            this.txtSubnet.Multiline = false;
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.PasswordChar = '\0';
            this.txtSubnet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubnet.SelectedText = "";
            this.txtSubnet.SelectionLength = 0;
            this.txtSubnet.SelectionStart = 0;
            this.txtSubnet.Size = new System.Drawing.Size(259, 48);
            this.txtSubnet.TabIndex = 34;
            this.txtSubnet.TabStop = false;
            this.txtSubnet.UseSystemPasswordChar = false;
            // 
            // txtGateway
            // 
            this.txtGateway.BackColor = System.Drawing.Color.White;
            this.txtGateway.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtGateway.BorderColorA = System.Drawing.Color.Coral;
            this.txtGateway.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtGateway.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGateway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtGateway.Hint = "";
            this.txtGateway.Location = new System.Drawing.Point(188, 291);
            this.txtGateway.MaxLength = 32767;
            this.txtGateway.Multiline = false;
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.PasswordChar = '\0';
            this.txtGateway.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGateway.SelectedText = "";
            this.txtGateway.SelectionLength = 0;
            this.txtGateway.SelectionStart = 0;
            this.txtGateway.Size = new System.Drawing.Size(259, 48);
            this.txtGateway.TabIndex = 35;
            this.txtGateway.TabStop = false;
            this.txtGateway.UseSystemPasswordChar = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtAciklama.BorderColorA = System.Drawing.Color.Coral;
            this.txtAciklama.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtAciklama.Hint = "";
            this.txtAciklama.Location = new System.Drawing.Point(188, 399);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = false;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.Size = new System.Drawing.Size(259, 48);
            this.txtAciklama.TabIndex = 36;
            this.txtAciklama.TabStop = false;
            this.txtAciklama.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 37;
            this.label1.Text = "➕";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblVlanEkle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 77);
            this.panel1.TabIndex = 38;
            // 
            // VlanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.txtVlanAdi);
            this.Controls.Add(this.txtVlanNo);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.lblVlanAdi);
            this.Controls.Add(this.lblVlanNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlRenk);
            this.Controls.Add(this.cmbKonum);
            this.Name = "VlanEkleForm";
            this.Text = "VlanEkleForm";
            this.Load += new System.EventHandler(this.VlanEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Panel pnlRenk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblVlanAdi;
        private System.Windows.Forms.Label lblVlanNo;
        private ReaLTaiizor.Controls.MoonLabel lblVlanEkle;
        private System.Windows.Forms.Label lblRenk;
        private ReaLTaiizor.Controls.HopeTextBox txtVlanNo;
        private ReaLTaiizor.Controls.HopeTextBox txtVlanAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtSubnet;
        private ReaLTaiizor.Controls.HopeTextBox txtGateway;
        private ReaLTaiizor.Controls.HopeTextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}