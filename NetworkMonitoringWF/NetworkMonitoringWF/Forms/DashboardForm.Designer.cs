namespace NetworkMonitoringWF.Forms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblToplamCihaz = new System.Windows.Forms.Label();
            this.lblAktifCihaz = new System.Windows.Forms.Label();
            this.lblPasifCihaz = new System.Windows.Forms.Label();
            this.lblBilinmeyenCihaz = new System.Windows.Forms.Label();
            this.lblServisDurum = new System.Windows.Forms.Label();
            this.lblSonKontrol = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnRaporOlustur = new ReaLTaiizor.Controls.HopeButton();
            this.pnlToplam = new ReaLTaiizor.Controls.LostBorderPanel();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblBil = new System.Windows.Forms.Label();
            this.lblPasif = new System.Windows.Forms.Label();
            this.lblAktif = new System.Windows.Forms.Label();
            this.pnlAktif = new ReaLTaiizor.Controls.LostBorderPanel();
            this.pnlPasif = new ReaLTaiizor.Controls.LostBorderPanel();
            this.pnlBil = new ReaLTaiizor.Controls.LostBorderPanel();
            this.pnlServisDurum = new ReaLTaiizor.Controls.LostBorderPanel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.pnlGraph2 = new System.Windows.Forms.Panel();
            this.chartCihazTipi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDurum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPingS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonIslem = new System.Windows.Forms.Label();
            this.pnlSon = new System.Windows.Forms.Panel();
            this.lblSonAlarm = new System.Windows.Forms.Label();
            this.lblSonIs = new System.Windows.Forms.Label();
            this.lblSonA = new System.Windows.Forms.Label();
            this.pnlToplam.SuspendLayout();
            this.pnlAktif.SuspendLayout();
            this.pnlPasif.SuspendLayout();
            this.pnlBil.SuspendLayout();
            this.pnlServisDurum.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGraph2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCihazTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).BeginInit();
            this.pnlSon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamCihaz
            // 
            this.lblToplamCihaz.AutoSize = true;
            this.lblToplamCihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCihaz.ForeColor = System.Drawing.Color.Black;
            this.lblToplamCihaz.Location = new System.Drawing.Point(31, 17);
            this.lblToplamCihaz.Name = "lblToplamCihaz";
            this.lblToplamCihaz.Size = new System.Drawing.Size(46, 52);
            this.lblToplamCihaz.TabIndex = 0;
            this.lblToplamCihaz.Text = "0";
            // 
            // lblAktifCihaz
            // 
            this.lblAktifCihaz.AutoSize = true;
            this.lblAktifCihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifCihaz.ForeColor = System.Drawing.Color.Lime;
            this.lblAktifCihaz.Location = new System.Drawing.Point(46, 17);
            this.lblAktifCihaz.Name = "lblAktifCihaz";
            this.lblAktifCihaz.Size = new System.Drawing.Size(46, 52);
            this.lblAktifCihaz.TabIndex = 1;
            this.lblAktifCihaz.Text = "0";
            // 
            // lblPasifCihaz
            // 
            this.lblPasifCihaz.AutoSize = true;
            this.lblPasifCihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasifCihaz.ForeColor = System.Drawing.Color.Red;
            this.lblPasifCihaz.Location = new System.Drawing.Point(30, 16);
            this.lblPasifCihaz.Name = "lblPasifCihaz";
            this.lblPasifCihaz.Size = new System.Drawing.Size(46, 52);
            this.lblPasifCihaz.TabIndex = 2;
            this.lblPasifCihaz.Text = "0";
            // 
            // lblBilinmeyenCihaz
            // 
            this.lblBilinmeyenCihaz.AutoSize = true;
            this.lblBilinmeyenCihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilinmeyenCihaz.ForeColor = System.Drawing.Color.DimGray;
            this.lblBilinmeyenCihaz.Location = new System.Drawing.Point(44, 16);
            this.lblBilinmeyenCihaz.Name = "lblBilinmeyenCihaz";
            this.lblBilinmeyenCihaz.Size = new System.Drawing.Size(46, 52);
            this.lblBilinmeyenCihaz.TabIndex = 3;
            this.lblBilinmeyenCihaz.Text = "0";
            // 
            // lblServisDurum
            // 
            this.lblServisDurum.AutoSize = true;
            this.lblServisDurum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServisDurum.ForeColor = System.Drawing.Color.DimGray;
            this.lblServisDurum.Location = new System.Drawing.Point(134, 16);
            this.lblServisDurum.Name = "lblServisDurum";
            this.lblServisDurum.Size = new System.Drawing.Size(77, 28);
            this.lblServisDurum.TabIndex = 4;
            this.lblServisDurum.Text = "Durum";
            this.lblServisDurum.Click += new System.EventHandler(this.lblServisDurum_Click);
            // 
            // lblSonKontrol
            // 
            this.lblSonKontrol.AutoSize = true;
            this.lblSonKontrol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSonKontrol.ForeColor = System.Drawing.Color.DimGray;
            this.lblSonKontrol.Location = new System.Drawing.Point(16, 56);
            this.lblSonKontrol.Name = "lblSonKontrol";
            this.lblSonKontrol.Size = new System.Drawing.Size(121, 28);
            this.lblSonKontrol.TabIndex = 5;
            this.lblSonKontrol.Text = "Son Kontrol:";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGeri.ForeColor = System.Drawing.Color.Black;
            this.btnGeri.Location = new System.Drawing.Point(1058, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(125, 51);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "↩   Ana Sayfa";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.BorderColor = System.Drawing.Color.Black;
            this.btnRaporOlustur.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnRaporOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporOlustur.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnRaporOlustur.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRaporOlustur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporOlustur.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnRaporOlustur.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnRaporOlustur.Location = new System.Drawing.Point(877, 14);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.PrimaryColor = System.Drawing.Color.Salmon;
            this.btnRaporOlustur.Size = new System.Drawing.Size(158, 49);
            this.btnRaporOlustur.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnRaporOlustur.TabIndex = 9;
            this.btnRaporOlustur.Text = "Rapor Oluştur";
            this.btnRaporOlustur.TextColor = System.Drawing.Color.Black;
            this.btnRaporOlustur.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // pnlToplam
            // 
            this.pnlToplam.BackColor = System.Drawing.Color.White;
            this.pnlToplam.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToplam.Controls.Add(this.lblTop);
            this.pnlToplam.Controls.Add(this.lblToplamCihaz);
            this.pnlToplam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlToplam.ForeColor = System.Drawing.Color.LightGray;
            this.pnlToplam.Location = new System.Drawing.Point(51, 96);
            this.pnlToplam.Name = "pnlToplam";
            this.pnlToplam.Padding = new System.Windows.Forms.Padding(5);
            this.pnlToplam.ShowText = true;
            this.pnlToplam.Size = new System.Drawing.Size(134, 100);
            this.pnlToplam.TabIndex = 10;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTop.ForeColor = System.Drawing.Color.DimGray;
            this.lblTop.Location = new System.Drawing.Point(6, 69);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(117, 25);
            this.lblTop.TabIndex = 11;
            this.lblTop.Text = "Toplam Cihaz";
            // 
            // lblBil
            // 
            this.lblBil.AutoSize = true;
            this.lblBil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBil.ForeColor = System.Drawing.Color.DimGray;
            this.lblBil.Location = new System.Drawing.Point(17, 68);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(97, 25);
            this.lblBil.TabIndex = 14;
            this.lblBil.Text = "Bilinmeyen";
            // 
            // lblPasif
            // 
            this.lblPasif.AutoSize = true;
            this.lblPasif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasif.ForeColor = System.Drawing.Color.DimGray;
            this.lblPasif.Location = new System.Drawing.Point(16, 68);
            this.lblPasif.Name = "lblPasif";
            this.lblPasif.Size = new System.Drawing.Size(95, 25);
            this.lblPasif.TabIndex = 13;
            this.lblPasif.Text = "Pasif Cihaz";
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktif.ForeColor = System.Drawing.Color.DimGray;
            this.lblAktif.Location = new System.Drawing.Point(21, 69);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(96, 25);
            this.lblAktif.TabIndex = 12;
            this.lblAktif.Text = "Aktif Cihaz";
            // 
            // pnlAktif
            // 
            this.pnlAktif.BackColor = System.Drawing.Color.White;
            this.pnlAktif.BorderColor = System.Drawing.Color.Transparent;
            this.pnlAktif.Controls.Add(this.lblAktif);
            this.pnlAktif.Controls.Add(this.lblAktifCihaz);
            this.pnlAktif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlAktif.ForeColor = System.Drawing.Color.White;
            this.pnlAktif.Location = new System.Drawing.Point(217, 96);
            this.pnlAktif.Name = "pnlAktif";
            this.pnlAktif.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAktif.ShowText = true;
            this.pnlAktif.Size = new System.Drawing.Size(134, 100);
            this.pnlAktif.TabIndex = 12;
            // 
            // pnlPasif
            // 
            this.pnlPasif.BackColor = System.Drawing.Color.White;
            this.pnlPasif.BorderColor = System.Drawing.Color.Transparent;
            this.pnlPasif.Controls.Add(this.lblPasif);
            this.pnlPasif.Controls.Add(this.lblPasifCihaz);
            this.pnlPasif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlPasif.ForeColor = System.Drawing.Color.White;
            this.pnlPasif.Location = new System.Drawing.Point(384, 96);
            this.pnlPasif.Name = "pnlPasif";
            this.pnlPasif.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPasif.ShowText = true;
            this.pnlPasif.Size = new System.Drawing.Size(134, 100);
            this.pnlPasif.TabIndex = 12;
            // 
            // pnlBil
            // 
            this.pnlBil.BackColor = System.Drawing.Color.White;
            this.pnlBil.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBil.Controls.Add(this.lblBil);
            this.pnlBil.Controls.Add(this.lblBilinmeyenCihaz);
            this.pnlBil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlBil.ForeColor = System.Drawing.Color.White;
            this.pnlBil.Location = new System.Drawing.Point(555, 96);
            this.pnlBil.Name = "pnlBil";
            this.pnlBil.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBil.ShowText = true;
            this.pnlBil.Size = new System.Drawing.Size(134, 100);
            this.pnlBil.TabIndex = 12;
            // 
            // pnlServisDurum
            // 
            this.pnlServisDurum.BackColor = System.Drawing.Color.White;
            this.pnlServisDurum.BorderColor = System.Drawing.Color.Transparent;
            this.pnlServisDurum.Controls.Add(this.lblPingS);
            this.pnlServisDurum.Controls.Add(this.lblServisDurum);
            this.pnlServisDurum.Controls.Add(this.lblSonKontrol);
            this.pnlServisDurum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlServisDurum.ForeColor = System.Drawing.Color.White;
            this.pnlServisDurum.Location = new System.Drawing.Point(736, 96);
            this.pnlServisDurum.Name = "pnlServisDurum";
            this.pnlServisDurum.Padding = new System.Windows.Forms.Padding(5);
            this.pnlServisDurum.ShowText = true;
            this.pnlServisDurum.Size = new System.Drawing.Size(384, 100);
            this.pnlServisDurum.TabIndex = 14;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel1.Location = new System.Drawing.Point(93, 21);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(164, 32);
            this.headerLabel1.TabIndex = 15;
            this.headerLabel1.Text = "DASHBOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.headerLabel1);
            this.panel1.Controls.Add(this.btnRaporOlustur);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 73);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "📊";
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.Location = new System.Drawing.Point(51, 281);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(503, 395);
            this.pnlGraph.TabIndex = 18;
            // 
            // pnlGraph2
            // 
            this.pnlGraph2.BackColor = System.Drawing.Color.White;
            this.pnlGraph2.Controls.Add(this.chartDurum);
            this.pnlGraph2.Location = new System.Drawing.Point(627, 281);
            this.pnlGraph2.Name = "pnlGraph2";
            this.pnlGraph2.Size = new System.Drawing.Size(493, 395);
            this.pnlGraph2.TabIndex = 19;
            // 
            // chartCihazTipi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCihazTipi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCihazTipi.Legends.Add(legend2);
            this.chartCihazTipi.Location = new System.Drawing.Point(58, 314);
            this.chartCihazTipi.Name = "chartCihazTipi";
            this.chartCihazTipi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCihazTipi.Series.Add(series2);
            this.chartCihazTipi.Size = new System.Drawing.Size(467, 353);
            this.chartCihazTipi.TabIndex = 17;
            this.chartCihazTipi.Text = "chart1";
            // 
            // chartDurum
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDurum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDurum.Legends.Add(legend1);
            this.chartDurum.Location = new System.Drawing.Point(24, 33);
            this.chartDurum.Name = "chartDurum";
            this.chartDurum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDurum.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.Silver};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDurum.Series.Add(series1);
            this.chartDurum.Size = new System.Drawing.Size(448, 353);
            this.chartDurum.TabIndex = 10;
            this.chartDurum.Text = "chart1";
            // 
            // lblPingS
            // 
            this.lblPingS.AutoSize = true;
            this.lblPingS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPingS.ForeColor = System.Drawing.Color.Black;
            this.lblPingS.Location = new System.Drawing.Point(15, 16);
            this.lblPingS.Name = "lblPingS";
            this.lblPingS.Size = new System.Drawing.Size(116, 28);
            this.lblPingS.TabIndex = 20;
            this.lblPingS.Text = "Ping Servisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ağdaki cihazların türlerine göre sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "📊 Cihaz Tipi Dağılımı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(623, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Aktif, pasif ve bilinmeyen cihaz oranları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(622, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "◔ Cihaz Durum Dağılımı";
            // 
            // lblSonIslem
            // 
            this.lblSonIslem.AutoSize = true;
            this.lblSonIslem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSonIslem.ForeColor = System.Drawing.Color.Black;
            this.lblSonIslem.Location = new System.Drawing.Point(122, 10);
            this.lblSonIslem.Name = "lblSonIslem";
            this.lblSonIslem.Size = new System.Drawing.Size(90, 25);
            this.lblSonIslem.TabIndex = 6;
            this.lblSonIslem.Text = "Son İşlem";
            // 
            // pnlSon
            // 
            this.pnlSon.BackColor = System.Drawing.Color.White;
            this.pnlSon.Controls.Add(this.lblSonA);
            this.pnlSon.Controls.Add(this.lblSonIs);
            this.pnlSon.Controls.Add(this.lblSonAlarm);
            this.pnlSon.Controls.Add(this.lblSonIslem);
            this.pnlSon.Location = new System.Drawing.Point(51, 694);
            this.pnlSon.Name = "pnlSon";
            this.pnlSon.Size = new System.Drawing.Size(1069, 77);
            this.pnlSon.TabIndex = 24;
            // 
            // lblSonAlarm
            // 
            this.lblSonAlarm.AutoSize = true;
            this.lblSonAlarm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSonAlarm.ForeColor = System.Drawing.Color.Black;
            this.lblSonAlarm.Location = new System.Drawing.Point(129, 42);
            this.lblSonAlarm.Name = "lblSonAlarm";
            this.lblSonAlarm.Size = new System.Drawing.Size(95, 25);
            this.lblSonAlarm.TabIndex = 7;
            this.lblSonAlarm.Text = "Son Alarm";
            // 
            // lblSonIs
            // 
            this.lblSonIs.AutoSize = true;
            this.lblSonIs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonIs.ForeColor = System.Drawing.Color.Black;
            this.lblSonIs.Location = new System.Drawing.Point(27, 10);
            this.lblSonIs.Name = "lblSonIs";
            this.lblSonIs.Size = new System.Drawing.Size(99, 25);
            this.lblSonIs.TabIndex = 8;
            this.lblSonIs.Text = "Son İşlem:";
            // 
            // lblSonA
            // 
            this.lblSonA.AutoSize = true;
            this.lblSonA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonA.ForeColor = System.Drawing.Color.Black;
            this.lblSonA.Location = new System.Drawing.Point(27, 42);
            this.lblSonA.Name = "lblSonA";
            this.lblSonA.Size = new System.Drawing.Size(105, 25);
            this.lblSonA.TabIndex = 9;
            this.lblSonA.Text = "Son Alarm:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 794);
            this.Controls.Add(this.pnlSon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlGraph2);
            this.Controls.Add(this.chartCihazTipi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlServisDurum);
            this.Controls.Add(this.pnlBil);
            this.Controls.Add(this.pnlPasif);
            this.Controls.Add(this.pnlAktif);
            this.Controls.Add(this.pnlToplam);
            this.Controls.Add(this.pnlGraph);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlToplam.ResumeLayout(false);
            this.pnlToplam.PerformLayout();
            this.pnlAktif.ResumeLayout(false);
            this.pnlAktif.PerformLayout();
            this.pnlPasif.ResumeLayout(false);
            this.pnlPasif.PerformLayout();
            this.pnlBil.ResumeLayout(false);
            this.pnlBil.PerformLayout();
            this.pnlServisDurum.ResumeLayout(false);
            this.pnlServisDurum.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGraph2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCihazTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).EndInit();
            this.pnlSon.ResumeLayout(false);
            this.pnlSon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamCihaz;
        private System.Windows.Forms.Label lblAktifCihaz;
        private System.Windows.Forms.Label lblPasifCihaz;
        private System.Windows.Forms.Label lblBilinmeyenCihaz;
        private System.Windows.Forms.Label lblServisDurum;
        private System.Windows.Forms.Label lblSonKontrol;
        private System.Windows.Forms.Button btnGeri;
        private ReaLTaiizor.Controls.HopeButton btnRaporOlustur;
        private ReaLTaiizor.Controls.LostBorderPanel pnlToplam;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBil;
        private System.Windows.Forms.Label lblPasif;
        private System.Windows.Forms.Label lblAktif;
        private ReaLTaiizor.Controls.LostBorderPanel pnlAktif;
        private ReaLTaiizor.Controls.LostBorderPanel pnlPasif;
        private ReaLTaiizor.Controls.LostBorderPanel pnlBil;
        private ReaLTaiizor.Controls.LostBorderPanel pnlServisDurum;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel pnlGraph2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDurum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCihazTipi;
        private System.Windows.Forms.Label lblPingS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonIslem;
        private System.Windows.Forms.Panel pnlSon;
        private System.Windows.Forms.Label lblSonA;
        private System.Windows.Forms.Label lblSonIs;
        private System.Windows.Forms.Label lblSonAlarm;
    }
}