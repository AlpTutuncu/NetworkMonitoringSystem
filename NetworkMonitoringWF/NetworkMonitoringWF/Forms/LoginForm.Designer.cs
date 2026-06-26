namespace NetworkMonitoringWF
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtSifre = new ReaLTaiizor.Controls.HopeTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new ReaLTaiizor.Controls.HopeButton();
            this.btnCikis = new ReaLTaiizor.Controls.HopeButton();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(180, 174);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(105, 22);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Coral;
            this.lblBaslik.Location = new System.Drawing.Point(132, 78);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(482, 40);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Network Monitoring System";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BaseColor = System.Drawing.Color.LightGray;
            this.txtKullaniciAdi.BorderColorA = System.Drawing.Color.Coral;
            this.txtKullaniciAdi.BorderColorB = System.Drawing.Color.LightGray;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtKullaniciAdi.Hint = "Kullanıcı Adı";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(182, 205);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(372, 48);
            this.txtKullaniciAdi.TabIndex = 7;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BaseColor = System.Drawing.Color.LightGray;
            this.txtSifre.BorderColorA = System.Drawing.Color.Coral;
            this.txtSifre.BorderColorB = System.Drawing.Color.LightGray;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.Location = new System.Drawing.Point(182, 310);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(372, 48);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.TabStop = false;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(180, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre";
            // 
            // btnGiris
            // 
            this.btnGiris.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnGiris.DefaultColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.HoverTextColor = System.Drawing.Color.DimGray;
            this.btnGiris.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnGiris.Location = new System.Drawing.Point(261, 397);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.PrimaryColor = System.Drawing.Color.White;
            this.btnGiris.Size = new System.Drawing.Size(207, 40);
            this.btnGiris.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.TextColor = System.Drawing.Color.Black;
            this.btnGiris.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCikis.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCikis.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCikis.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCikis.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCikis.Location = new System.Drawing.Point(12, 483);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PrimaryColor = System.Drawing.Color.LightCoral;
            this.btnCikis.Size = new System.Drawing.Size(82, 40);
            this.btnCikis.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "⏻";
            this.btnCikis.TextColor = System.Drawing.Color.White;
            this.btnCikis.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 535);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Network Monitoring System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblBaslik;
        private ReaLTaiizor.Controls.HopeTextBox txtKullaniciAdi;
        private ReaLTaiizor.Controls.HopeTextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeButton btnGiris;
        private ReaLTaiizor.Controls.HopeButton btnCikis;
    }
}

