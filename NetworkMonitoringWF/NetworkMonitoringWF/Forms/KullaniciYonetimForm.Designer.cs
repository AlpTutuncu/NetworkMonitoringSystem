namespace NetworkMonitoringWF.Forms
{
    partial class KullaniciYonetimForm
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
            this.dgvKullanicilar = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnGeri = new ReaLTaiizor.Controls.HopeButton();
            this.lblKullaniciHeader = new System.Windows.Forms.Label();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtSifre = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtKullaniciAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new ReaLTaiizor.Controls.HopeButton();
            this.btnEkle = new ReaLTaiizor.Controls.HopeButton();
            this.btnGuncelle = new ReaLTaiizor.Controls.HopeButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.pnlBilgiler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToResizeRows = false;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKullanicilar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKullanicilar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKullanicilar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKullanicilar.EnableHeadersVisualStyles = false;
            this.dgvKullanicilar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvKullanicilar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 72);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKullanicilar.RowHeadersVisible = false;
            this.dgvKullanicilar.RowHeadersWidth = 62;
            this.dgvKullanicilar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKullanicilar.RowTemplate.Height = 50;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(739, 591);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellClick);
            // 
            // btnGeri
            // 
            this.btnGeri.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeri.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGeri.DefaultColor = System.Drawing.Color.White;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGeri.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnGeri.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGeri.Location = new System.Drawing.Point(1027, 16);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.PrimaryColor = System.Drawing.SystemColors.Control;
            this.btnGeri.Size = new System.Drawing.Size(138, 40);
            this.btnGeri.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "↩   Ana Sayfa";
            this.btnGeri.TextColor = System.Drawing.Color.Black;
            this.btnGeri.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKullaniciHeader
            // 
            this.lblKullaniciHeader.AutoSize = true;
            this.lblKullaniciHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciHeader.ForeColor = System.Drawing.Color.Coral;
            this.lblKullaniciHeader.Location = new System.Drawing.Point(101, 19);
            this.lblKullaniciHeader.Name = "lblKullaniciHeader";
            this.lblKullaniciHeader.Size = new System.Drawing.Size(263, 32);
            this.lblKullaniciHeader.TabIndex = 11;
            this.lblKullaniciHeader.Text = "KULLANICI YÖNETİMİ";
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.BackColor = System.Drawing.Color.White;
            this.pnlBilgiler.Controls.Add(this.lblRol);
            this.pnlBilgiler.Controls.Add(this.lblSifre);
            this.pnlBilgiler.Controls.Add(this.lblKullanici);
            this.pnlBilgiler.Controls.Add(this.cmbRol);
            this.pnlBilgiler.Controls.Add(this.txtSifre);
            this.pnlBilgiler.Controls.Add(this.txtKullaniciAdi);
            this.pnlBilgiler.Location = new System.Drawing.Point(778, 147);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(373, 357);
            this.pnlBilgiler.TabIndex = 12;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.Location = new System.Drawing.Point(47, 252);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 21);
            this.lblRol.TabIndex = 16;
            this.lblRol.Text = "Rol";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(47, 137);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(42, 21);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(47, 29);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(95, 21);
            this.lblKullanici.TabIndex = 14;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(51, 278);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(276, 30);
            this.cmbRol.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSifre.BorderColorA = System.Drawing.Color.Coral;
            this.txtSifre.BorderColorB = System.Drawing.Color.Gray;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSifre.Hint = "";
            this.txtSifre.Location = new System.Drawing.Point(51, 170);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(276, 48);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.TabStop = false;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtKullaniciAdi.BorderColorA = System.Drawing.Color.Coral;
            this.txtKullaniciAdi.BorderColorB = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtKullaniciAdi.Hint = "";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(51, 62);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(276, 48);
            this.txtKullaniciAdi.TabIndex = 11;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.lblKullaniciHeader);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 70);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(17, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "👥";
            // 
            // btnSil
            // 
            this.btnSil.BorderColor = System.Drawing.Color.Silver;
            this.btnSil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSil.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSil.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSil.Location = new System.Drawing.Point(910, 520);
            this.btnSil.Name = "btnSil";
            this.btnSil.PrimaryColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(98, 72);
            this.btnSil.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextColor = System.Drawing.Color.Black;
            this.btnSil.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderColor = System.Drawing.Color.Silver;
            this.btnEkle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEkle.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnEkle.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEkle.Location = new System.Drawing.Point(795, 520);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PrimaryColor = System.Drawing.Color.LightGreen;
            this.btnEkle.Size = new System.Drawing.Size(97, 72);
            this.btnEkle.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.Black;
            this.btnEkle.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderColor = System.Drawing.Color.Silver;
            this.btnGuncelle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGuncelle.DefaultColor = System.Drawing.Color.LightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnGuncelle.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGuncelle.Location = new System.Drawing.Point(1025, 520);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PrimaryColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(109, 72);
            this.btnGuncelle.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.Color.Black;
            this.btnGuncelle.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(871, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kullanıcı Bilgileri";
            // 
            // KullaniciYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 677);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.btnSil);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KullaniciYonetimForm";
            this.Text = "KullaniciYonetimForm";
            this.Load += new System.EventHandler(this.KullaniciYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvKullanicilar;
        private ReaLTaiizor.Controls.HopeButton btnGeri;
        private System.Windows.Forms.Label lblKullaniciHeader;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ComboBox cmbRol;
        private ReaLTaiizor.Controls.HopeTextBox txtSifre;
        private ReaLTaiizor.Controls.HopeTextBox txtKullaniciAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeButton btnGuncelle;
        private ReaLTaiizor.Controls.HopeButton btnEkle;
        private ReaLTaiizor.Controls.HopeButton btnSil;
        private System.Windows.Forms.Label label2;
    }
}