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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnServisBaslat = new System.Windows.Forms.Button();
            this.btnServisDurdur = new System.Windows.Forms.Button();
            this.lblServisDurum = new System.Windows.Forms.Label();
            this.pnlAlarm = new System.Windows.Forms.Panel();
            this.btnAlarmKapat = new ReaLTaiizor.Controls.HopeButton();
            this.lblAlarmMesaj = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.pnlCihazYonetimi = new System.Windows.Forms.Panel();
            this.lblCihazAciklama = new System.Windows.Forms.Label();
            this.lblCihazDurum = new System.Windows.Forms.Label();
            this.lblCihazBaslik = new System.Windows.Forms.Label();
            this.lblCihazIcon = new System.Windows.Forms.Label();
            this.pnlSistemKayitlari = new System.Windows.Forms.Panel();
            this.lblSistemAciklama = new System.Windows.Forms.Label();
            this.lblSistemDurum = new System.Windows.Forms.Label();
            this.lblSistemBaslik = new System.Windows.Forms.Label();
            this.lblSistemIcon = new System.Windows.Forms.Label();
            this.pnlTopoloji = new System.Windows.Forms.Panel();
            this.lblTopolojiAciklama = new System.Windows.Forms.Label();
            this.lblTopolojiDurum = new System.Windows.Forms.Label();
            this.lblTopolojiBaslik = new System.Windows.Forms.Label();
            this.lblTopolojiIcon = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboardAciklama = new System.Windows.Forms.Label();
            this.lblDashboardDurum = new System.Windows.Forms.Label();
            this.lblDashboardBaslik = new System.Windows.Forms.Label();
            this.lblDashboardIcon = new System.Windows.Forms.Label();
            this.pnlPingKayitlari = new System.Windows.Forms.Panel();
            this.lblPingKayitlariAciklama = new System.Windows.Forms.Label();
            this.lblPingKayitlariDurum = new System.Windows.Forms.Label();
            this.lblPingKayitlariBaslik = new System.Windows.Forms.Label();
            this.lblPingKayitlariIcon = new System.Windows.Forms.Label();
            this.pnlVlanYonetimi = new System.Windows.Forms.Panel();
            this.lblVlanYonetimiAciklama = new System.Windows.Forms.Label();
            this.lblVlanYonetimiDurum = new System.Windows.Forms.Label();
            this.lblVlanYonetimiBaslik = new System.Windows.Forms.Label();
            this.lblVlanYonetimiIcon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslikIcon = new System.Windows.Forms.Label();
            this.pnlPingServisDurum = new System.Windows.Forms.Panel();
            this.lblSD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAlarm.SuspendLayout();
            this.pnlCihazYonetimi.SuspendLayout();
            this.pnlSistemKayitlari.SuspendLayout();
            this.pnlTopoloji.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlPingKayitlari.SuspendLayout();
            this.pnlVlanYonetimi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPingServisDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(174, 85);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(94, 28);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı";
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnCikis.Location = new System.Drawing.Point(897, 18);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(122, 41);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "↩   Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnServisBaslat
            // 
            this.btnServisBaslat.Location = new System.Drawing.Point(839, 10);
            this.btnServisBaslat.Name = "btnServisBaslat";
            this.btnServisBaslat.Size = new System.Drawing.Size(88, 39);
            this.btnServisBaslat.TabIndex = 4;
            this.btnServisBaslat.Text = "▶ Başlat";
            this.btnServisBaslat.UseVisualStyleBackColor = true;
            this.btnServisBaslat.Click += new System.EventHandler(this.btnServisBaslat_Click);
            // 
            // btnServisDurdur
            // 
            this.btnServisDurdur.Location = new System.Drawing.Point(932, 10);
            this.btnServisDurdur.Name = "btnServisDurdur";
            this.btnServisDurdur.Size = new System.Drawing.Size(88, 39);
            this.btnServisDurdur.TabIndex = 5;
            this.btnServisDurdur.Text = "⏹ Durdur";
            this.btnServisDurdur.UseVisualStyleBackColor = true;
            this.btnServisDurdur.Click += new System.EventHandler(this.btnServisDurdur_Click);
            // 
            // lblServisDurum
            // 
            this.lblServisDurum.AutoSize = true;
            this.lblServisDurum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServisDurum.Location = new System.Drawing.Point(202, 11);
            this.lblServisDurum.Name = "lblServisDurum";
            this.lblServisDurum.Size = new System.Drawing.Size(109, 38);
            this.lblServisDurum.TabIndex = 6;
            this.lblServisDurum.Text = "Durum";
            // 
            // pnlAlarm
            // 
            this.pnlAlarm.Controls.Add(this.btnAlarmKapat);
            this.pnlAlarm.Controls.Add(this.lblAlarmMesaj);
            this.pnlAlarm.Location = new System.Drawing.Point(39, 585);
            this.pnlAlarm.Name = "pnlAlarm";
            this.pnlAlarm.Size = new System.Drawing.Size(941, 93);
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
            this.btnAlarmKapat.Location = new System.Drawing.Point(13, 49);
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
            this.lblAlarmMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmMesaj.Location = new System.Drawing.Point(8, 11);
            this.lblAlarmMesaj.Name = "lblAlarmMesaj";
            this.lblAlarmMesaj.Size = new System.Drawing.Size(664, 26);
            this.lblAlarmMesaj.TabIndex = 12;
            this.lblAlarmMesaj.Text = "Server4 cihazı çok Aktif durumundan birazcık Pasif durumuna geçti.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Coral;
            this.lblHeader.Location = new System.Drawing.Point(87, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(398, 32);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "NETWORK MONITORING SYSTEM";
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(720, 19);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(171, 41);
            this.btnKullaniciYonetimi.TabIndex = 13;
            this.btnKullaniciYonetimi.Text = "👥  Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // pnlCihazYonetimi
            // 
            this.pnlCihazYonetimi.BackColor = System.Drawing.Color.White;
            this.pnlCihazYonetimi.Controls.Add(this.lblCihazAciklama);
            this.pnlCihazYonetimi.Controls.Add(this.lblCihazDurum);
            this.pnlCihazYonetimi.Controls.Add(this.lblCihazBaslik);
            this.pnlCihazYonetimi.Controls.Add(this.lblCihazIcon);
            this.pnlCihazYonetimi.Location = new System.Drawing.Point(39, 132);
            this.pnlCihazYonetimi.Name = "pnlCihazYonetimi";
            this.pnlCihazYonetimi.Size = new System.Drawing.Size(302, 207);
            this.pnlCihazYonetimi.TabIndex = 15;
            // 
            // lblCihazAciklama
            // 
            this.lblCihazAciklama.AutoSize = true;
            this.lblCihazAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblCihazAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblCihazAciklama.Name = "lblCihazAciklama";
            this.lblCihazAciklama.Size = new System.Drawing.Size(257, 25);
            this.lblCihazAciklama.TabIndex = 21;
            this.lblCihazAciklama.Text = "Ağdaki cihazları listele ve yönet";
            // 
            // lblCihazDurum
            // 
            this.lblCihazDurum.AutoSize = true;
            this.lblCihazDurum.BackColor = System.Drawing.Color.LightGreen;
            this.lblCihazDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazDurum.Location = new System.Drawing.Point(29, 160);
            this.lblCihazDurum.Name = "lblCihazDurum";
            this.lblCihazDurum.Size = new System.Drawing.Size(71, 21);
            this.lblCihazDurum.TabIndex = 22;
            this.lblCihazDurum.Text = "142 aktif";
            // 
            // lblCihazBaslik
            // 
            this.lblCihazBaslik.AutoSize = true;
            this.lblCihazBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblCihazBaslik.Name = "lblCihazBaslik";
            this.lblCihazBaslik.Size = new System.Drawing.Size(183, 32);
            this.lblCihazBaslik.TabIndex = 20;
            this.lblCihazBaslik.Text = "Cihaz Yönetimi";
            // 
            // lblCihazIcon
            // 
            this.lblCihazIcon.AutoSize = true;
            this.lblCihazIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazIcon.Location = new System.Drawing.Point(21, 26);
            this.lblCihazIcon.Name = "lblCihazIcon";
            this.lblCihazIcon.Size = new System.Drawing.Size(69, 48);
            this.lblCihazIcon.TabIndex = 19;
            this.lblCihazIcon.Text = "🖥";
            // 
            // pnlSistemKayitlari
            // 
            this.pnlSistemKayitlari.BackColor = System.Drawing.Color.White;
            this.pnlSistemKayitlari.Controls.Add(this.lblSistemAciklama);
            this.pnlSistemKayitlari.Controls.Add(this.lblSistemDurum);
            this.pnlSistemKayitlari.Controls.Add(this.lblSistemBaslik);
            this.pnlSistemKayitlari.Controls.Add(this.lblSistemIcon);
            this.pnlSistemKayitlari.Location = new System.Drawing.Point(358, 132);
            this.pnlSistemKayitlari.Name = "pnlSistemKayitlari";
            this.pnlSistemKayitlari.Size = new System.Drawing.Size(302, 207);
            this.pnlSistemKayitlari.TabIndex = 23;
            // 
            // lblSistemAciklama
            // 
            this.lblSistemAciklama.AutoSize = true;
            this.lblSistemAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblSistemAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblSistemAciklama.Name = "lblSistemAciklama";
            this.lblSistemAciklama.Size = new System.Drawing.Size(230, 25);
            this.lblSistemAciklama.TabIndex = 21;
            this.lblSistemAciklama.Text = "Sistem işlemlerini görüntüle";
            // 
            // lblSistemDurum
            // 
            this.lblSistemDurum.AutoSize = true;
            this.lblSistemDurum.BackColor = System.Drawing.Color.Khaki;
            this.lblSistemDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemDurum.Location = new System.Drawing.Point(29, 160);
            this.lblSistemDurum.Name = "lblSistemDurum";
            this.lblSistemDurum.Size = new System.Drawing.Size(93, 21);
            this.lblSistemDurum.TabIndex = 22;
            this.lblSistemDurum.Text = "Log geçmişi";
            // 
            // lblSistemBaslik
            // 
            this.lblSistemBaslik.AutoSize = true;
            this.lblSistemBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblSistemBaslik.Name = "lblSistemBaslik";
            this.lblSistemBaslik.Size = new System.Drawing.Size(191, 32);
            this.lblSistemBaslik.TabIndex = 20;
            this.lblSistemBaslik.Text = "Sistem Kayıtları";
            // 
            // lblSistemIcon
            // 
            this.lblSistemIcon.AutoSize = true;
            this.lblSistemIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemIcon.Location = new System.Drawing.Point(21, 26);
            this.lblSistemIcon.Name = "lblSistemIcon";
            this.lblSistemIcon.Size = new System.Drawing.Size(69, 48);
            this.lblSistemIcon.TabIndex = 19;
            this.lblSistemIcon.Text = "📝";
            // 
            // pnlTopoloji
            // 
            this.pnlTopoloji.BackColor = System.Drawing.Color.White;
            this.pnlTopoloji.Controls.Add(this.lblTopolojiAciklama);
            this.pnlTopoloji.Controls.Add(this.lblTopolojiDurum);
            this.pnlTopoloji.Controls.Add(this.lblTopolojiBaslik);
            this.pnlTopoloji.Controls.Add(this.lblTopolojiIcon);
            this.pnlTopoloji.Location = new System.Drawing.Point(678, 132);
            this.pnlTopoloji.Name = "pnlTopoloji";
            this.pnlTopoloji.Size = new System.Drawing.Size(302, 207);
            this.pnlTopoloji.TabIndex = 24;
            // 
            // lblTopolojiAciklama
            // 
            this.lblTopolojiAciklama.AutoSize = true;
            this.lblTopolojiAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopolojiAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblTopolojiAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblTopolojiAciklama.Name = "lblTopolojiAciklama";
            this.lblTopolojiAciklama.Size = new System.Drawing.Size(253, 25);
            this.lblTopolojiAciklama.TabIndex = 21;
            this.lblTopolojiAciklama.Text = "Bağlantıları görüntüle ve yönet";
            // 
            // lblTopolojiDurum
            // 
            this.lblTopolojiDurum.AutoSize = true;
            this.lblTopolojiDurum.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblTopolojiDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopolojiDurum.Location = new System.Drawing.Point(29, 160);
            this.lblTopolojiDurum.Name = "lblTopolojiDurum";
            this.lblTopolojiDurum.Size = new System.Drawing.Size(142, 21);
            this.lblTopolojiDurum.TabIndex = 22;
            this.lblTopolojiDurum.Text = "Topoloji görünümü";
            // 
            // lblTopolojiBaslik
            // 
            this.lblTopolojiBaslik.AutoSize = true;
            this.lblTopolojiBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopolojiBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblTopolojiBaslik.Name = "lblTopolojiBaslik";
            this.lblTopolojiBaslik.Size = new System.Drawing.Size(164, 32);
            this.lblTopolojiBaslik.TabIndex = 20;
            this.lblTopolojiBaslik.Text = "Ağ Topolojisi";
            // 
            // lblTopolojiIcon
            // 
            this.lblTopolojiIcon.AutoSize = true;
            this.lblTopolojiIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopolojiIcon.Location = new System.Drawing.Point(21, 26);
            this.lblTopolojiIcon.Name = "lblTopolojiIcon";
            this.lblTopolojiIcon.Size = new System.Drawing.Size(69, 48);
            this.lblTopolojiIcon.TabIndex = 19;
            this.lblTopolojiIcon.Text = "🕸️";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.lblDashboardAciklama);
            this.pnlDashboard.Controls.Add(this.lblDashboardDurum);
            this.pnlDashboard.Controls.Add(this.lblDashboardBaslik);
            this.pnlDashboard.Controls.Add(this.lblDashboardIcon);
            this.pnlDashboard.Location = new System.Drawing.Point(39, 357);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(302, 207);
            this.pnlDashboard.TabIndex = 25;
            // 
            // lblDashboardAciklama
            // 
            this.lblDashboardAciklama.AutoSize = true;
            this.lblDashboardAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboardAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboardAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblDashboardAciklama.Name = "lblDashboardAciklama";
            this.lblDashboardAciklama.Size = new System.Drawing.Size(205, 25);
            this.lblDashboardAciklama.TabIndex = 21;
            this.lblDashboardAciklama.Text = "Ağ istatistiklerini takip et";
            // 
            // lblDashboardDurum
            // 
            this.lblDashboardDurum.AutoSize = true;
            this.lblDashboardDurum.BackColor = System.Drawing.Color.LightCoral;
            this.lblDashboardDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboardDurum.Location = new System.Drawing.Point(29, 160);
            this.lblDashboardDurum.Name = "lblDashboardDurum";
            this.lblDashboardDurum.Size = new System.Drawing.Size(66, 21);
            this.lblDashboardDurum.TabIndex = 22;
            this.lblDashboardDurum.Text = "Ağ özeti";
            // 
            // lblDashboardBaslik
            // 
            this.lblDashboardBaslik.AutoSize = true;
            this.lblDashboardBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboardBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblDashboardBaslik.Name = "lblDashboardBaslik";
            this.lblDashboardBaslik.Size = new System.Drawing.Size(138, 32);
            this.lblDashboardBaslik.TabIndex = 20;
            this.lblDashboardBaslik.Text = "Dashboard";
            // 
            // lblDashboardIcon
            // 
            this.lblDashboardIcon.AutoSize = true;
            this.lblDashboardIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboardIcon.Location = new System.Drawing.Point(21, 26);
            this.lblDashboardIcon.Name = "lblDashboardIcon";
            this.lblDashboardIcon.Size = new System.Drawing.Size(69, 48);
            this.lblDashboardIcon.TabIndex = 19;
            this.lblDashboardIcon.Text = "📊";
            // 
            // pnlPingKayitlari
            // 
            this.pnlPingKayitlari.BackColor = System.Drawing.Color.White;
            this.pnlPingKayitlari.Controls.Add(this.lblPingKayitlariAciklama);
            this.pnlPingKayitlari.Controls.Add(this.lblPingKayitlariDurum);
            this.pnlPingKayitlari.Controls.Add(this.lblPingKayitlariBaslik);
            this.pnlPingKayitlari.Controls.Add(this.lblPingKayitlariIcon);
            this.pnlPingKayitlari.Location = new System.Drawing.Point(358, 357);
            this.pnlPingKayitlari.Name = "pnlPingKayitlari";
            this.pnlPingKayitlari.Size = new System.Drawing.Size(302, 207);
            this.pnlPingKayitlari.TabIndex = 26;
            // 
            // lblPingKayitlariAciklama
            // 
            this.lblPingKayitlariAciklama.AutoSize = true;
            this.lblPingKayitlariAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPingKayitlariAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblPingKayitlariAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblPingKayitlariAciklama.Name = "lblPingKayitlariAciklama";
            this.lblPingKayitlariAciklama.Size = new System.Drawing.Size(191, 25);
            this.lblPingKayitlariAciklama.TabIndex = 21;
            this.lblPingKayitlariAciklama.Text = "Ping durumlarını incele";
            // 
            // lblPingKayitlariDurum
            // 
            this.lblPingKayitlariDurum.AutoSize = true;
            this.lblPingKayitlariDurum.BackColor = System.Drawing.Color.Pink;
            this.lblPingKayitlariDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPingKayitlariDurum.Location = new System.Drawing.Point(29, 160);
            this.lblPingKayitlariDurum.Name = "lblPingKayitlariDurum";
            this.lblPingKayitlariDurum.Size = new System.Drawing.Size(89, 21);
            this.lblPingKayitlariDurum.TabIndex = 22;
            this.lblPingKayitlariDurum.Text = "Ping logları";
            // 
            // lblPingKayitlariBaslik
            // 
            this.lblPingKayitlariBaslik.AutoSize = true;
            this.lblPingKayitlariBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPingKayitlariBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblPingKayitlariBaslik.Name = "lblPingKayitlariBaslik";
            this.lblPingKayitlariBaslik.Size = new System.Drawing.Size(168, 32);
            this.lblPingKayitlariBaslik.TabIndex = 20;
            this.lblPingKayitlariBaslik.Text = "Ping Kayıtları";
            // 
            // lblPingKayitlariIcon
            // 
            this.lblPingKayitlariIcon.AutoSize = true;
            this.lblPingKayitlariIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPingKayitlariIcon.Location = new System.Drawing.Point(21, 26);
            this.lblPingKayitlariIcon.Name = "lblPingKayitlariIcon";
            this.lblPingKayitlariIcon.Size = new System.Drawing.Size(69, 48);
            this.lblPingKayitlariIcon.TabIndex = 19;
            this.lblPingKayitlariIcon.Text = "📡";
            // 
            // pnlVlanYonetimi
            // 
            this.pnlVlanYonetimi.BackColor = System.Drawing.Color.White;
            this.pnlVlanYonetimi.Controls.Add(this.lblVlanYonetimiAciklama);
            this.pnlVlanYonetimi.Controls.Add(this.lblVlanYonetimiDurum);
            this.pnlVlanYonetimi.Controls.Add(this.lblVlanYonetimiBaslik);
            this.pnlVlanYonetimi.Controls.Add(this.lblVlanYonetimiIcon);
            this.pnlVlanYonetimi.Location = new System.Drawing.Point(678, 357);
            this.pnlVlanYonetimi.Name = "pnlVlanYonetimi";
            this.pnlVlanYonetimi.Size = new System.Drawing.Size(302, 207);
            this.pnlVlanYonetimi.TabIndex = 27;
            // 
            // lblVlanYonetimiAciklama
            // 
            this.lblVlanYonetimiAciklama.AutoSize = true;
            this.lblVlanYonetimiAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanYonetimiAciklama.ForeColor = System.Drawing.Color.DimGray;
            this.lblVlanYonetimiAciklama.Location = new System.Drawing.Point(24, 116);
            this.lblVlanYonetimiAciklama.Name = "lblVlanYonetimiAciklama";
            this.lblVlanYonetimiAciklama.Size = new System.Drawing.Size(198, 25);
            this.lblVlanYonetimiAciklama.TabIndex = 21;
            this.lblVlanYonetimiAciklama.Text = "VLAN özelliklerini yönet";
            // 
            // lblVlanYonetimiDurum
            // 
            this.lblVlanYonetimiDurum.AutoSize = true;
            this.lblVlanYonetimiDurum.BackColor = System.Drawing.Color.Orange;
            this.lblVlanYonetimiDurum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanYonetimiDurum.Location = new System.Drawing.Point(29, 160);
            this.lblVlanYonetimiDurum.Name = "lblVlanYonetimiDurum";
            this.lblVlanYonetimiDurum.Size = new System.Drawing.Size(113, 21);
            this.lblVlanYonetimiDurum.TabIndex = 22;
            this.lblVlanYonetimiDurum.Text = "VLAN işlemleri";
            // 
            // lblVlanYonetimiBaslik
            // 
            this.lblVlanYonetimiBaslik.AutoSize = true;
            this.lblVlanYonetimiBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanYonetimiBaslik.Location = new System.Drawing.Point(23, 84);
            this.lblVlanYonetimiBaslik.Name = "lblVlanYonetimiBaslik";
            this.lblVlanYonetimiBaslik.Size = new System.Drawing.Size(187, 32);
            this.lblVlanYonetimiBaslik.TabIndex = 20;
            this.lblVlanYonetimiBaslik.Text = "VLAN Yönetimi";
            // 
            // lblVlanYonetimiIcon
            // 
            this.lblVlanYonetimiIcon.AutoSize = true;
            this.lblVlanYonetimiIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanYonetimiIcon.Location = new System.Drawing.Point(21, 26);
            this.lblVlanYonetimiIcon.Name = "lblVlanYonetimiIcon";
            this.lblVlanYonetimiIcon.Size = new System.Drawing.Size(69, 48);
            this.lblVlanYonetimiIcon.TabIndex = 19;
            this.lblVlanYonetimiIcon.Text = "🔀";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBaslikIcon);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnKullaniciYonetimi);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 76);
            this.panel1.TabIndex = 28;
            // 
            // lblBaslikIcon
            // 
            this.lblBaslikIcon.AutoSize = true;
            this.lblBaslikIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikIcon.ForeColor = System.Drawing.Color.Coral;
            this.lblBaslikIcon.Location = new System.Drawing.Point(8, 6);
            this.lblBaslikIcon.Name = "lblBaslikIcon";
            this.lblBaslikIcon.Size = new System.Drawing.Size(84, 59);
            this.lblBaslikIcon.TabIndex = 29;
            this.lblBaslikIcon.Text = "🌐";
            // 
            // pnlPingServisDurum
            // 
            this.pnlPingServisDurum.BackColor = System.Drawing.Color.White;
            this.pnlPingServisDurum.Controls.Add(this.lblSD);
            this.pnlPingServisDurum.Controls.Add(this.btnServisDurdur);
            this.pnlPingServisDurum.Controls.Add(this.btnServisBaslat);
            this.pnlPingServisDurum.Controls.Add(this.lblServisDurum);
            this.pnlPingServisDurum.Location = new System.Drawing.Point(-5, 697);
            this.pnlPingServisDurum.Name = "pnlPingServisDurum";
            this.pnlPingServisDurum.Size = new System.Drawing.Size(1032, 60);
            this.pnlPingServisDurum.TabIndex = 30;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSD.Location = new System.Drawing.Point(17, 10);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(189, 38);
            this.lblSD.TabIndex = 31;
            this.lblSD.Text = "Servis Durum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hoşgeldiniz, ";
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPingServisDurum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVlanYonetimi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.pnlPingKayitlari);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTopoloji);
            this.Controls.Add(this.pnlSistemKayitlari);
            this.Controls.Add(this.pnlCihazYonetimi);
            this.Controls.Add(this.pnlAlarm);
            this.Name = "AnaSayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfaForm";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            this.pnlAlarm.ResumeLayout(false);
            this.pnlAlarm.PerformLayout();
            this.pnlCihazYonetimi.ResumeLayout(false);
            this.pnlCihazYonetimi.PerformLayout();
            this.pnlSistemKayitlari.ResumeLayout(false);
            this.pnlSistemKayitlari.PerformLayout();
            this.pnlTopoloji.ResumeLayout(false);
            this.pnlTopoloji.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlPingKayitlari.ResumeLayout(false);
            this.pnlPingKayitlari.PerformLayout();
            this.pnlVlanYonetimi.ResumeLayout(false);
            this.pnlVlanYonetimi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPingServisDurum.ResumeLayout(false);
            this.pnlPingServisDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnServisBaslat;
        private System.Windows.Forms.Button btnServisDurdur;
        private System.Windows.Forms.Label lblServisDurum;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label lblAlarmMesaj;
        private ReaLTaiizor.Controls.HopeButton btnAlarmKapat;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Panel pnlCihazYonetimi;
        private System.Windows.Forms.Label lblCihazAciklama;
        private System.Windows.Forms.Label lblCihazDurum;
        private System.Windows.Forms.Label lblCihazBaslik;
        private System.Windows.Forms.Label lblCihazIcon;
        private System.Windows.Forms.Panel pnlSistemKayitlari;
        private System.Windows.Forms.Label lblSistemAciklama;
        private System.Windows.Forms.Label lblSistemDurum;
        private System.Windows.Forms.Label lblSistemBaslik;
        private System.Windows.Forms.Label lblSistemIcon;
        private System.Windows.Forms.Panel pnlTopoloji;
        private System.Windows.Forms.Label lblTopolojiAciklama;
        private System.Windows.Forms.Label lblTopolojiDurum;
        private System.Windows.Forms.Label lblTopolojiBaslik;
        private System.Windows.Forms.Label lblTopolojiIcon;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboardAciklama;
        private System.Windows.Forms.Label lblDashboardDurum;
        private System.Windows.Forms.Label lblDashboardBaslik;
        private System.Windows.Forms.Label lblDashboardIcon;
        private System.Windows.Forms.Panel pnlPingKayitlari;
        private System.Windows.Forms.Label lblPingKayitlariAciklama;
        private System.Windows.Forms.Label lblPingKayitlariDurum;
        private System.Windows.Forms.Label lblPingKayitlariBaslik;
        private System.Windows.Forms.Label lblPingKayitlariIcon;
        private System.Windows.Forms.Panel pnlVlanYonetimi;
        private System.Windows.Forms.Label lblVlanYonetimiAciklama;
        private System.Windows.Forms.Label lblVlanYonetimiDurum;
        private System.Windows.Forms.Label lblVlanYonetimiBaslik;
        private System.Windows.Forms.Label lblVlanYonetimiIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslikIcon;
        private System.Windows.Forms.Panel pnlPingServisDurum;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label label1;
    }
}