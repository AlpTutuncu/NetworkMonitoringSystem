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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlRenk = new System.Windows.Forms.Panel();
            this.lblGateway = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCihazIcon = new System.Windows.Forms.Label();
            this.pnlIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKonum
            // 
            this.cmbKonum.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(133, 95);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(402, 29);
            this.cmbKonum.TabIndex = 7;
            this.cmbKonum.SelectedIndexChanged += new System.EventHandler(this.cmbKonum_SelectedIndexChanged);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(1121, 10);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGeri.Size = new System.Drawing.Size(152, 54);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "↩   Ana Sayfa";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAra.Location = new System.Drawing.Point(310, 685);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 48);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTemizle.Location = new System.Drawing.Point(403, 685);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 48);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pnlRenk
            // 
            this.pnlRenk.Location = new System.Drawing.Point(30, 385);
            this.pnlRenk.Name = "pnlRenk";
            this.pnlRenk.Size = new System.Drawing.Size(39, 33);
            this.pnlRenk.TabIndex = 9;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGateway.ForeColor = System.Drawing.Color.Coral;
            this.lblGateway.Location = new System.Drawing.Point(22, 296);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(87, 28);
            this.lblGateway.TabIndex = 6;
            this.lblGateway.Text = "Gateway";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSil.Location = new System.Drawing.Point(696, 685);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 48);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGuncelle.Location = new System.Drawing.Point(807, 685);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 48);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEkle.Location = new System.Drawing.Point(585, 685);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 48);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Coral;
            this.lblAciklama.Location = new System.Drawing.Point(23, 127);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(91, 28);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubnet.ForeColor = System.Drawing.Color.Coral;
            this.lblSubnet.Location = new System.Drawing.Point(23, 210);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(74, 28);
            this.lblSubnet.TabIndex = 3;
            this.lblSubnet.Text = "Subnet";
            // 
            // lblVlanAdi
            // 
            this.lblVlanAdi.AutoSize = true;
            this.lblVlanAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanAdi.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanAdi.Location = new System.Drawing.Point(23, 48);
            this.lblVlanAdi.Name = "lblVlanAdi";
            this.lblVlanAdi.Size = new System.Drawing.Size(37, 28);
            this.lblVlanAdi.TabIndex = 2;
            this.lblVlanAdi.Text = "Ad";
            // 
            // lblVlanNo
            // 
            this.lblVlanNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanNo.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanNo.Location = new System.Drawing.Point(32, 6);
            this.lblVlanNo.Name = "lblVlanNo";
            this.lblVlanNo.Size = new System.Drawing.Size(66, 37);
            this.lblVlanNo.TabIndex = 1;
            this.lblVlanNo.Text = "0";
            this.lblVlanNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCihazSayisi
            // 
            this.lblCihazSayisi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazSayisi.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazSayisi.Location = new System.Drawing.Point(145, 6);
            this.lblCihazSayisi.Name = "lblCihazSayisi";
            this.lblCihazSayisi.Size = new System.Drawing.Size(78, 37);
            this.lblCihazSayisi.TabIndex = 8;
            this.lblCihazSayisi.Text = "0";
            this.lblCihazSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblID.Location = new System.Drawing.Point(22, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 25);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "VLAN ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi
            // 
            this.lblSayi.Font = new System.Drawing.Font("Segoe UI", 8.25F);
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
            this.pnlIstatistik.Location = new System.Drawing.Point(971, 131);
            this.pnlIstatistik.Name = "pnlIstatistik";
            this.pnlIstatistik.Size = new System.Drawing.Size(235, 90);
            this.pnlIstatistik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Açıklama";
            // 
            // lblSubnett
            // 
            this.lblSubnett.AutoSize = true;
            this.lblSubnett.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSubnett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblSubnett.Location = new System.Drawing.Point(24, 184);
            this.lblSubnett.Name = "lblSubnett";
            this.lblSubnett.Size = new System.Drawing.Size(64, 23);
            this.lblSubnett.TabIndex = 0;
            this.lblSubnett.Text = "Subnet";
            // 
            // lblRenkE
            // 
            this.lblRenkE.AutoSize = true;
            this.lblRenkE.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblRenkE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblRenkE.Location = new System.Drawing.Point(23, 352);
            this.lblRenkE.Name = "lblRenkE";
            this.lblRenkE.Size = new System.Drawing.Size(98, 23);
            this.lblRenkE.TabIndex = 1;
            this.lblRenkE.Text = "Renk Etiketi";
            this.lblRenkE.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGatewayy
            // 
            this.lblGatewayy.AutoSize = true;
            this.lblGatewayy.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGatewayy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblGatewayy.Location = new System.Drawing.Point(24, 269);
            this.lblGatewayy.Name = "lblGatewayy";
            this.lblGatewayy.Size = new System.Drawing.Size(75, 23);
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
            this.txtAra.Location = new System.Drawing.Point(22, 685);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Multiline = false;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(282, 48);
            this.txtAra.TabIndex = 16;
            this.txtAra.TabStop = false;
            this.txtAra.UseSystemPasswordChar = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel1.Location = new System.Drawing.Point(100, 18);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(203, 32);
            this.headerLabel1.TabIndex = 17;
            this.headerLabel1.Text = "VLAN YÖNETİMİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(21, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(889, 539);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Konum Seç:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblGateway);
            this.panel1.Controls.Add(this.pnlRenk);
            this.panel1.Controls.Add(this.lblAciklama);
            this.panel1.Controls.Add(this.lblSubnet);
            this.panel1.Controls.Add(this.lblSubnett);
            this.panel1.Controls.Add(this.lblVlanAdi);
            this.panel1.Controls.Add(this.lblRenkE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblGatewayy);
            this.panel1.Location = new System.Drawing.Point(916, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 443);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCihazIcon);
            this.panel2.Controls.Add(this.headerLabel1);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Location = new System.Drawing.Point(-4, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 73);
            this.panel2.TabIndex = 21;
            // 
            // lblCihazIcon
            // 
            this.lblCihazIcon.AutoSize = true;
            this.lblCihazIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazIcon.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazIcon.Location = new System.Drawing.Point(17, 7);
            this.lblCihazIcon.Name = "lblCihazIcon";
            this.lblCihazIcon.Size = new System.Drawing.Size(78, 54);
            this.lblCihazIcon.TabIndex = 18;
            this.lblCihazIcon.Text = "🔀";
            // 
            // VlanYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1285, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pnlIstatistik);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbKonum);
            this.Name = "VlanYonetimForm";
            this.Text = "VlanYonetimForm";
            this.Load += new System.EventHandler(this.VlanYonetimForm_Load);
            this.pnlIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel pnlRenk;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Button btnSil;
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
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCihazIcon;
    }
}