namespace NetworkMonitoringWF.Forms
{
    partial class VlanGuncelleForm
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
            this.lblVlanG = new ReaLTaiizor.Controls.MoonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtAciklama = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtGateway = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtSubnet = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtVlanAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtVlanNo = new ReaLTaiizor.Controls.HopeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlRenk = new System.Windows.Forms.Panel();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblVlanG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 77);
            this.panel1.TabIndex = 54;
            // 
            // lblVlanG
            // 
            this.lblVlanG.AutoSize = true;
            this.lblVlanG.BackColor = System.Drawing.Color.Transparent;
            this.lblVlanG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVlanG.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanG.Location = new System.Drawing.Point(76, 22);
            this.lblVlanG.Name = "lblVlanG";
            this.lblVlanG.Size = new System.Drawing.Size(204, 32);
            this.lblVlanG.TabIndex = 13;
            this.lblVlanG.Text = "VLAN GÜNCELLE";
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
            this.label1.Text = "✏️";
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
            this.txtAciklama.TabIndex = 53;
            this.txtAciklama.TabStop = false;
            this.txtAciklama.UseSystemPasswordChar = false;
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
            this.txtGateway.TabIndex = 52;
            this.txtGateway.TabStop = false;
            this.txtGateway.UseSystemPasswordChar = false;
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
            this.txtSubnet.TabIndex = 51;
            this.txtSubnet.TabStop = false;
            this.txtSubnet.UseSystemPasswordChar = false;
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
            this.txtVlanAdi.TabIndex = 50;
            this.txtVlanAdi.TabStop = false;
            this.txtVlanAdi.UseSystemPasswordChar = false;
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
            this.txtVlanNo.TabIndex = 49;
            this.txtVlanNo.TabStop = false;
            this.txtVlanNo.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Renk Etiketi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Gateway:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Konum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(82, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Subnet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(61, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "VLAN Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(64, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "VLAN No:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(216, 537);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(197, 42);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pnlRenk
            // 
            this.pnlRenk.Location = new System.Drawing.Point(188, 468);
            this.pnlRenk.Name = "pnlRenk";
            this.pnlRenk.Size = new System.Drawing.Size(46, 37);
            this.pnlRenk.TabIndex = 41;
            this.pnlRenk.Click += new System.EventHandler(this.pnlRenk_Click);
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(188, 356);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(259, 28);
            this.cmbKonum.TabIndex = 40;
            // 
            // VlanGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.txtVlanAdi);
            this.Controls.Add(this.txtVlanNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlRenk);
            this.Controls.Add(this.cmbKonum);
            this.Name = "VlanGuncelleForm";
            this.Text = "VlanGuncelleForm";
            this.Load += new System.EventHandler(this.VlanGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MoonLabel lblVlanG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private ReaLTaiizor.Controls.HopeTextBox txtAciklama;
        private ReaLTaiizor.Controls.HopeTextBox txtGateway;
        private ReaLTaiizor.Controls.HopeTextBox txtSubnet;
        private ReaLTaiizor.Controls.HopeTextBox txtVlanAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtVlanNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlRenk;
        private System.Windows.Forms.ComboBox cmbKonum;
    }
}