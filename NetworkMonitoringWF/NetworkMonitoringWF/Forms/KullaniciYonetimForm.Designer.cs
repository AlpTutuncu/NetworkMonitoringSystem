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
            this.txtKullaniciAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtSifre = new ReaLTaiizor.Controls.HopeTextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnEkle = new ReaLTaiizor.Controls.HopeButton();
            this.btnSil = new ReaLTaiizor.Controls.HopeButton();
            this.btnGuncelle = new ReaLTaiizor.Controls.HopeButton();
            this.btnGeri = new ReaLTaiizor.Controls.HopeButton();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblKullaniciHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
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
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 108);
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
            this.dgvKullanicilar.Size = new System.Drawing.Size(599, 456);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellClick);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtKullaniciAdi.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtKullaniciAdi.Hint = "";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(661, 164);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(276, 48);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSifre.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtSifre.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSifre.Hint = "";
            this.txtSifre.Location = new System.Drawing.Point(661, 267);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(276, 48);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TabStop = false;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(661, 370);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(276, 30);
            this.cmbRol.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnEkle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEkle.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEkle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnEkle.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEkle.Location = new System.Drawing.Point(673, 439);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PrimaryColor = System.Drawing.Color.Coral;
            this.btnEkle.Size = new System.Drawing.Size(108, 36);
            this.btnEkle.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.White;
            this.btnEkle.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSil.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSil.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSil.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSil.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSil.Location = new System.Drawing.Point(813, 439);
            this.btnSil.Name = "btnSil";
            this.btnSil.PrimaryColor = System.Drawing.Color.Coral;
            this.btnSil.Size = new System.Drawing.Size(109, 36);
            this.btnSil.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextColor = System.Drawing.Color.White;
            this.btnSil.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnGuncelle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGuncelle.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuncelle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnGuncelle.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGuncelle.Location = new System.Drawing.Point(739, 493);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PrimaryColor = System.Drawing.Color.Coral;
            this.btnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.btnGuncelle.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.Color.White;
            this.btnGuncelle.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BorderColor = System.Drawing.Color.Coral;
            this.btnGeri.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGeri.DefaultColor = System.Drawing.Color.White;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnGeri.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.PrimaryColor = System.Drawing.SystemColors.Control;
            this.btnGeri.Size = new System.Drawing.Size(161, 38);
            this.btnGeri.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Ana Sayfaya Dön";
            this.btnGeri.TextColor = System.Drawing.Color.Black;
            this.btnGeri.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(657, 132);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(108, 22);
            this.lblKullanici.TabIndex = 8;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(657, 235);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(47, 22);
            this.lblSifre.TabIndex = 9;
            this.lblSifre.Text = "Şifre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.Location = new System.Drawing.Point(657, 345);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(37, 22);
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "Rol";
            // 
            // lblKullaniciHeader
            // 
            this.lblKullaniciHeader.AutoSize = true;
            this.lblKullaniciHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciHeader.ForeColor = System.Drawing.Color.Coral;
            this.lblKullaniciHeader.Location = new System.Drawing.Point(363, 37);
            this.lblKullaniciHeader.Name = "lblKullaniciHeader";
            this.lblKullaniciHeader.Size = new System.Drawing.Size(288, 37);
            this.lblKullaniciHeader.TabIndex = 11;
            this.lblKullaniciHeader.Text = "Kullanıcı Yönetimi";
            // 
            // KullaniciYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 582);
            this.Controls.Add(this.lblKullaniciHeader);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "KullaniciYonetimForm";
            this.Text = "KullaniciYonetimForm";
            this.Load += new System.EventHandler(this.KullaniciYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvKullanicilar;
        private ReaLTaiizor.Controls.HopeTextBox txtKullaniciAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtSifre;
        private System.Windows.Forms.ComboBox cmbRol;
        private ReaLTaiizor.Controls.HopeButton btnEkle;
        private ReaLTaiizor.Controls.HopeButton btnSil;
        private ReaLTaiizor.Controls.HopeButton btnGuncelle;
        private ReaLTaiizor.Controls.HopeButton btnGeri;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblKullaniciHeader;
    }
}