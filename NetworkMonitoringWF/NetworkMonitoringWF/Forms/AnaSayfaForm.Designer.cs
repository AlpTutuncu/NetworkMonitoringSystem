namespace NetworkMonitoringWF
{
    partial class AnaSayfaForm
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnCihazYonetimi = new System.Windows.Forms.Button();
            this.btnLoglar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnServisBaslat = new System.Windows.Forms.Button();
            this.btnServisDurdur = new System.Windows.Forms.Button();
            this.lblServisDurum = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTopoloji = new System.Windows.Forms.Button();
            this.btnPingLog = new System.Windows.Forms.Button();
            this.btnVlanYonetimi = new System.Windows.Forms.Button();
            this.pnlAlarm = new System.Windows.Forms.Panel();
            this.btnAlarmKapat = new ReaLTaiizor.Controls.HopeButton();
            this.lblAlarmMesaj = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.pnlAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Coral;
            this.lblKullanici.Location = new System.Drawing.Point(12, 19);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(190, 22);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Hoşgeldiniz + Kullanıcı";
            // 
            // btnCihazYonetimi
            // 
            this.btnCihazYonetimi.Location = new System.Drawing.Point(219, 145);
            this.btnCihazYonetimi.Name = "btnCihazYonetimi";
            this.btnCihazYonetimi.Size = new System.Drawing.Size(133, 99);
            this.btnCihazYonetimi.TabIndex = 1;
            this.btnCihazYonetimi.Text = "Cihaz Yönetimi";
            this.btnCihazYonetimi.UseVisualStyleBackColor = true;
            this.btnCihazYonetimi.Click += new System.EventHandler(this.btnCihazYonetimi_Click);
            // 
            // btnLoglar
            // 
            this.btnLoglar.Location = new System.Drawing.Point(358, 145);
            this.btnLoglar.Name = "btnLoglar";
            this.btnLoglar.Size = new System.Drawing.Size(133, 99);
            this.btnLoglar.TabIndex = 2;
            this.btnLoglar.Text = "Sistem Kayıtları";
            this.btnLoglar.UseVisualStyleBackColor = true;
            this.btnLoglar.Click += new System.EventHandler(this.btnLoglar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(12, 483);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(133, 45);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnServisBaslat
            // 
            this.btnServisBaslat.Location = new System.Drawing.Point(616, 486);
            this.btnServisBaslat.Name = "btnServisBaslat";
            this.btnServisBaslat.Size = new System.Drawing.Size(88, 39);
            this.btnServisBaslat.TabIndex = 4;
            this.btnServisBaslat.Text = "Başlat";
            this.btnServisBaslat.UseVisualStyleBackColor = true;
            this.btnServisBaslat.Click += new System.EventHandler(this.btnServisBaslat_Click);
            // 
            // btnServisDurdur
            // 
            this.btnServisDurdur.Location = new System.Drawing.Point(710, 486);
            this.btnServisDurdur.Name = "btnServisDurdur";
            this.btnServisDurdur.Size = new System.Drawing.Size(88, 39);
            this.btnServisDurdur.TabIndex = 5;
            this.btnServisDurdur.Text = "Durdur";
            this.btnServisDurdur.UseVisualStyleBackColor = true;
            this.btnServisDurdur.Click += new System.EventHandler(this.btnServisDurdur_Click);
            // 
            // lblServisDurum
            // 
            this.lblServisDurum.AutoSize = true;
            this.lblServisDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServisDurum.Location = new System.Drawing.Point(442, 493);
            this.lblServisDurum.Name = "lblServisDurum";
            this.lblServisDurum.Size = new System.Drawing.Size(70, 25);
            this.lblServisDurum.TabIndex = 6;
            this.lblServisDurum.Text = "Durum";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(219, 250);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 99);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTopoloji
            // 
            this.btnTopoloji.Location = new System.Drawing.Point(497, 145);
            this.btnTopoloji.Name = "btnTopoloji";
            this.btnTopoloji.Size = new System.Drawing.Size(133, 99);
            this.btnTopoloji.TabIndex = 8;
            this.btnTopoloji.Text = "Ağ Topolojisi";
            this.btnTopoloji.UseVisualStyleBackColor = true;
            this.btnTopoloji.Click += new System.EventHandler(this.btnTopoloji_Click);
            // 
            // btnPingLog
            // 
            this.btnPingLog.Location = new System.Drawing.Point(358, 250);
            this.btnPingLog.Name = "btnPingLog";
            this.btnPingLog.Size = new System.Drawing.Size(133, 99);
            this.btnPingLog.TabIndex = 9;
            this.btnPingLog.Text = "Ping Kayıtları";
            this.btnPingLog.UseVisualStyleBackColor = true;
            this.btnPingLog.Click += new System.EventHandler(this.btnPingLog_Click);
            // 
            // btnVlanYonetimi
            // 
            this.btnVlanYonetimi.Location = new System.Drawing.Point(497, 250);
            this.btnVlanYonetimi.Name = "btnVlanYonetimi";
            this.btnVlanYonetimi.Size = new System.Drawing.Size(133, 99);
            this.btnVlanYonetimi.TabIndex = 10;
            this.btnVlanYonetimi.Text = "VLAN Yönetimi";
            this.btnVlanYonetimi.UseVisualStyleBackColor = true;
            this.btnVlanYonetimi.Click += new System.EventHandler(this.btnVlanYonetimi_Click);
            // 
            // pnlAlarm
            // 
            this.pnlAlarm.Controls.Add(this.btnAlarmKapat);
            this.pnlAlarm.Controls.Add(this.lblAlarmMesaj);
            this.pnlAlarm.Location = new System.Drawing.Point(156, 355);
            this.pnlAlarm.Name = "pnlAlarm";
            this.pnlAlarm.Size = new System.Drawing.Size(562, 93);
            this.pnlAlarm.TabIndex = 11;
            this.pnlAlarm.Visible = false;
            // 
            // btnAlarmKapat
            // 
            this.btnAlarmKapat.BorderColor = System.Drawing.Color.Maroon;
            this.btnAlarmKapat.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAlarmKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmKapat.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAlarmKapat.DefaultColor = System.Drawing.Color.Blue;
            this.btnAlarmKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmKapat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlarmKapat.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAlarmKapat.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAlarmKapat.Location = new System.Drawing.Point(200, 50);
            this.btnAlarmKapat.Name = "btnAlarmKapat";
            this.btnAlarmKapat.PrimaryColor = System.Drawing.Color.LightCoral;
            this.btnAlarmKapat.Size = new System.Drawing.Size(135, 33);
            this.btnAlarmKapat.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAlarmKapat.TabIndex = 13;
            this.btnAlarmKapat.Text = "Anlaşıldı";
            this.btnAlarmKapat.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlarmKapat.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAlarmKapat.Click += new System.EventHandler(this.btnAlarmKapat_Click);
            // 
            // lblAlarmMesaj
            // 
            this.lblAlarmMesaj.AutoSize = true;
            this.lblAlarmMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmMesaj.Location = new System.Drawing.Point(3, 13);
            this.lblAlarmMesaj.Name = "lblAlarmMesaj";
            this.lblAlarmMesaj.Size = new System.Drawing.Size(544, 22);
            this.lblAlarmMesaj.TabIndex = 12;
            this.lblAlarmMesaj.Text = "Server4 cihazı çok Aktif durumundan birazcık Pasif durumuna geçti.";
            this.lblAlarmMesaj.Click += new System.EventHandler(this.lblAlarmMesaj_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.Coral;
            this.lblHeader.Location = new System.Drawing.Point(185, 77);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(492, 32);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "NETWORK MONITORING SYSTEM";
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(675, 12);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(144, 41);
            this.btnKullaniciYonetimi.TabIndex = 13;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 537);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlAlarm);
            this.Controls.Add(this.btnVlanYonetimi);
            this.Controls.Add(this.btnPingLog);
            this.Controls.Add(this.btnTopoloji);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblServisDurum);
            this.Controls.Add(this.btnServisDurdur);
            this.Controls.Add(this.btnServisBaslat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnLoglar);
            this.Controls.Add(this.btnCihazYonetimi);
            this.Controls.Add(this.lblKullanici);
            this.Name = "AnaSayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfaForm";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            this.pnlAlarm.ResumeLayout(false);
            this.pnlAlarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnCihazYonetimi;
        private System.Windows.Forms.Button btnLoglar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnServisBaslat;
        private System.Windows.Forms.Button btnServisDurdur;
        private System.Windows.Forms.Label lblServisDurum;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTopoloji;
        private System.Windows.Forms.Button btnPingLog;
        private System.Windows.Forms.Button btnVlanYonetimi;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label lblAlarmMesaj;
        private ReaLTaiizor.Controls.HopeButton btnAlarmKapat;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
    }
}