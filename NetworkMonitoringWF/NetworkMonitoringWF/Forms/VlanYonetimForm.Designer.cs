namespace NetworkMonitoringWF.Forms
{
    partial class VlanYonetimForm
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lstVlanlar = new System.Windows.Forms.ListBox();
            this.pnlRenk = new System.Windows.Forms.Panel();
            this.lblGateway = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKonum = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblVlanAdi = new System.Windows.Forms.Label();
            this.lblVlanNo = new System.Windows.Forms.Label();
            this.lblCihazSayisi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.pnlIstatistik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubnett = new System.Windows.Forms.Label();
            this.lblRenkE = new System.Windows.Forms.Label();
            this.lblGatewayy = new System.Windows.Forms.Label();
            this.txtAra = new ReaLTaiizor.Controls.HopeTextBox();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.pnlIstatistik.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(12, 96);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(374, 28);
            this.cmbKonum.TabIndex = 7;
            this.cmbKonum.Text = "Konum Seç";
            this.cmbKonum.SelectedIndexChanged += new System.EventHandler(this.cmbKonum_SelectedIndexChanged);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(152, 37);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Ana Sayfaya Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(191, 130);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 48);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(284, 130);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 48);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstVlanlar
            // 
            this.lstVlanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVlanlar.FormattingEnabled = true;
            this.lstVlanlar.ItemHeight = 25;
            this.lstVlanlar.Location = new System.Drawing.Point(12, 185);
            this.lstVlanlar.Name = "lstVlanlar";
            this.lstVlanlar.Size = new System.Drawing.Size(374, 429);
            this.lstVlanlar.TabIndex = 13;
            this.lstVlanlar.SelectedIndexChanged += new System.EventHandler(this.lstVlanlar_SelectedIndexChanged);
            // 
            // pnlRenk
            // 
            this.pnlRenk.Location = new System.Drawing.Point(425, 569);
            this.pnlRenk.Name = "pnlRenk";
            this.pnlRenk.Size = new System.Drawing.Size(39, 33);
            this.pnlRenk.TabIndex = 9;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGateway.ForeColor = System.Drawing.Color.Coral;
            this.lblGateway.Location = new System.Drawing.Point(417, 480);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(106, 29);
            this.lblGateway.TabIndex = 6;
            this.lblGateway.Text = "Gateway";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(145, 626);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 54);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(714, 663);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(59, 20);
            this.lblKonum.TabIndex = 5;
            this.lblKonum.Text = "Konum";
            this.lblKonum.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(256, 626);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 54);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(34, 626);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Coral;
            this.lblAciklama.Location = new System.Drawing.Point(418, 311);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(110, 29);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubnet.ForeColor = System.Drawing.Color.Coral;
            this.lblSubnet.Location = new System.Drawing.Point(418, 394);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(89, 29);
            this.lblSubnet.TabIndex = 3;
            this.lblSubnet.Text = "Subnet";
            // 
            // lblVlanAdi
            // 
            this.lblVlanAdi.AutoSize = true;
            this.lblVlanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanAdi.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanAdi.Location = new System.Drawing.Point(418, 232);
            this.lblVlanAdi.Name = "lblVlanAdi";
            this.lblVlanAdi.Size = new System.Drawing.Size(42, 29);
            this.lblVlanAdi.TabIndex = 2;
            this.lblVlanAdi.Text = "Ad";
            // 
            // lblVlanNo
            // 
            this.lblVlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanNo.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanNo.Location = new System.Drawing.Point(32, 13);
            this.lblVlanNo.Name = "lblVlanNo";
            this.lblVlanNo.Size = new System.Drawing.Size(66, 37);
            this.lblVlanNo.TabIndex = 1;
            this.lblVlanNo.Text = "0";
            this.lblVlanNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCihazSayisi
            // 
            this.lblCihazSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazSayisi.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazSayisi.Location = new System.Drawing.Point(145, 13);
            this.lblCihazSayisi.Name = "lblCihazSayisi";
            this.lblCihazSayisi.Size = new System.Drawing.Size(78, 37);
            this.lblCihazSayisi.TabIndex = 8;
            this.lblCihazSayisi.Text = "0";
            this.lblCihazSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(22, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 25);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "VLAN ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi
            // 
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(151, 50);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(63, 25);
            this.lblSayi.TabIndex = 15;
            this.lblSayi.Text = "Cihaz";
            this.lblSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIstatistik
            // 
            this.pnlIstatistik.BackColor = System.Drawing.Color.White;
            this.pnlIstatistik.Controls.Add(this.lblSayi);
            this.pnlIstatistik.Controls.Add(this.lblID);
            this.pnlIstatistik.Controls.Add(this.lblVlanNo);
            this.pnlIstatistik.Controls.Add(this.lblCihazSayisi);
            this.pnlIstatistik.Location = new System.Drawing.Point(482, 96);
            this.pnlIstatistik.Name = "pnlIstatistik";
            this.pnlIstatistik.Size = new System.Drawing.Size(235, 90);
            this.pnlIstatistik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(418, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(418, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Açıklama";
            // 
            // lblSubnett
            // 
            this.lblSubnett.AutoSize = true;
            this.lblSubnett.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubnett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblSubnett.Location = new System.Drawing.Point(419, 368);
            this.lblSubnett.Name = "lblSubnett";
            this.lblSubnett.Size = new System.Drawing.Size(67, 22);
            this.lblSubnett.TabIndex = 0;
            this.lblSubnett.Text = "Subnet";
            // 
            // lblRenkE
            // 
            this.lblRenkE.AutoSize = true;
            this.lblRenkE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenkE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblRenkE.Location = new System.Drawing.Point(418, 536);
            this.lblRenkE.Name = "lblRenkE";
            this.lblRenkE.Size = new System.Drawing.Size(106, 22);
            this.lblRenkE.TabIndex = 1;
            this.lblRenkE.Text = "Renk Etiketi";
            this.lblRenkE.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGatewayy
            // 
            this.lblGatewayy.AutoSize = true;
            this.lblGatewayy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGatewayy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblGatewayy.Location = new System.Drawing.Point(419, 453);
            this.lblGatewayy.Name = "lblGatewayy";
            this.lblGatewayy.Size = new System.Drawing.Size(81, 22);
            this.lblGatewayy.TabIndex = 2;
            this.lblGatewayy.Text = "Gateway";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.White;
            this.txtAra.BaseColor = System.Drawing.Color.Transparent;
            this.txtAra.BorderColorA = System.Drawing.Color.Transparent;
            this.txtAra.BorderColorB = System.Drawing.Color.Transparent;
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtAra.Hint = "VLAN Ara";
            this.txtAra.Location = new System.Drawing.Point(12, 130);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Multiline = false;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(173, 48);
            this.txtAra.TabIndex = 16;
            this.txtAra.TabStop = false;
            this.txtAra.UseSystemPasswordChar = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel1.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel1.Location = new System.Drawing.Point(249, 35);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(279, 37);
            this.headerLabel1.TabIndex = 17;
            this.headerLabel1.Text = "VLAN YÖNETİMİ";
            // 
            // VlanYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 695);
            this.Controls.Add(this.headerLabel1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblSubnett);
            this.Controls.Add(this.lblRenkE);
            this.Controls.Add(this.lblGatewayy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlIstatistik);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblVlanAdi);
            this.Controls.Add(this.lstVlanlar);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.cmbKonum);
            this.Controls.Add(this.pnlRenk);
            this.Controls.Add(this.lblGateway);
            this.Name = "VlanYonetimForm";
            this.Text = "VlanYonetimForm";
            this.Load += new System.EventHandler(this.VlanYonetimForm_Load);
            this.pnlIstatistik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lstVlanlar;
        private System.Windows.Forms.Panel pnlRenk;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblVlanAdi;
        private System.Windows.Forms.Label lblVlanNo;
        private System.Windows.Forms.Label lblCihazSayisi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Panel pnlIstatistik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRenkE;
        private System.Windows.Forms.Label lblSubnett;
        private System.Windows.Forms.Label lblGatewayy;
        private ReaLTaiizor.Controls.HopeTextBox txtAra;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
    }
}