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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblToplamCihaz = new System.Windows.Forms.Label();
            this.lblAktifCihaz = new System.Windows.Forms.Label();
            this.lblPasifCihaz = new System.Windows.Forms.Label();
            this.lblBilinmeyenCihaz = new System.Windows.Forms.Label();
            this.lblServisDurum = new System.Windows.Forms.Label();
            this.lblSonKontrol = new System.Windows.Forms.Label();
            this.lblSonIslem = new System.Windows.Forms.Label();
            this.chartDurum = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).BeginInit();
            this.pnlToplam.SuspendLayout();
            this.pnlAktif.SuspendLayout();
            this.pnlPasif.SuspendLayout();
            this.pnlBil.SuspendLayout();
            this.pnlServisDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamCihaz
            // 
            this.lblToplamCihaz.AutoSize = true;
            this.lblToplamCihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCihaz.ForeColor = System.Drawing.Color.Black;
            this.lblToplamCihaz.Location = new System.Drawing.Point(38, 17);
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
            this.lblPasifCihaz.Location = new System.Drawing.Point(37, 16);
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
            this.lblServisDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServisDurum.ForeColor = System.Drawing.Color.DimGray;
            this.lblServisDurum.Location = new System.Drawing.Point(5, 13);
            this.lblServisDurum.Name = "lblServisDurum";
            this.lblServisDurum.Size = new System.Drawing.Size(155, 22);
            this.lblServisDurum.TabIndex = 4;
            this.lblServisDurum.Text = "Ping Servisi: Pasif";
            this.lblServisDurum.Click += new System.EventHandler(this.lblServisDurum_Click);
            // 
            // lblSonKontrol
            // 
            this.lblSonKontrol.AutoSize = true;
            this.lblSonKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonKontrol.ForeColor = System.Drawing.Color.DimGray;
            this.lblSonKontrol.Location = new System.Drawing.Point(5, 46);
            this.lblSonKontrol.Name = "lblSonKontrol";
            this.lblSonKontrol.Size = new System.Drawing.Size(109, 22);
            this.lblSonKontrol.TabIndex = 5;
            this.lblSonKontrol.Text = "Son Kontrol:";
            // 
            // lblSonIslem
            // 
            this.lblSonIslem.AutoSize = true;
            this.lblSonIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonIslem.Location = new System.Drawing.Point(78, 475);
            this.lblSonIslem.Name = "lblSonIslem";
            this.lblSonIslem.Size = new System.Drawing.Size(93, 22);
            this.lblSonIslem.TabIndex = 6;
            this.lblSonIslem.Text = "Son İşlem:";
            // 
            // chartDurum
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDurum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDurum.Legends.Add(legend1);
            this.chartDurum.Location = new System.Drawing.Point(438, 114);
            this.chartDurum.Name = "chartDurum";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDurum.Series.Add(series1);
            this.chartDurum.Size = new System.Drawing.Size(424, 427);
            this.chartDurum.TabIndex = 7;
            this.chartDurum.Text = "chart1";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(144, 33);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Ana Sayfaya Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnRaporOlustur.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnRaporOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporOlustur.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnRaporOlustur.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRaporOlustur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporOlustur.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnRaporOlustur.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnRaporOlustur.Location = new System.Drawing.Point(12, 537);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.btnRaporOlustur.Size = new System.Drawing.Size(141, 46);
            this.btnRaporOlustur.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnRaporOlustur.TabIndex = 9;
            this.btnRaporOlustur.Text = "Rapor Oluştur";
            this.btnRaporOlustur.TextColor = System.Drawing.Color.White;
            this.btnRaporOlustur.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // pnlToplam
            // 
            this.pnlToplam.BackColor = System.Drawing.Color.Linen;
            this.pnlToplam.BorderColor = System.Drawing.Color.Transparent;
            this.pnlToplam.Controls.Add(this.lblTop);
            this.pnlToplam.Controls.Add(this.lblToplamCihaz);
            this.pnlToplam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlToplam.ForeColor = System.Drawing.Color.LightGray;
            this.pnlToplam.Location = new System.Drawing.Point(74, 131);
            this.pnlToplam.Name = "pnlToplam";
            this.pnlToplam.Padding = new System.Windows.Forms.Padding(5);
            this.pnlToplam.ShowText = true;
            this.pnlToplam.Size = new System.Drawing.Size(134, 100);
            this.pnlToplam.TabIndex = 10;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTop.ForeColor = System.Drawing.Color.DimGray;
            this.lblTop.Location = new System.Drawing.Point(6, 69);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(120, 22);
            this.lblTop.TabIndex = 11;
            this.lblTop.Text = "Toplam Cihaz";
            // 
            // lblBil
            // 
            this.lblBil.AutoSize = true;
            this.lblBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBil.ForeColor = System.Drawing.Color.DimGray;
            this.lblBil.Location = new System.Drawing.Point(17, 68);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(97, 22);
            this.lblBil.TabIndex = 14;
            this.lblBil.Text = "Bilinmeyen";
            // 
            // lblPasif
            // 
            this.lblPasif.AutoSize = true;
            this.lblPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasif.ForeColor = System.Drawing.Color.DimGray;
            this.lblPasif.Location = new System.Drawing.Point(16, 68);
            this.lblPasif.Name = "lblPasif";
            this.lblPasif.Size = new System.Drawing.Size(100, 22);
            this.lblPasif.TabIndex = 13;
            this.lblPasif.Text = "Pasif Cihaz";
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktif.ForeColor = System.Drawing.Color.DimGray;
            this.lblAktif.Location = new System.Drawing.Point(21, 69);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(95, 22);
            this.lblAktif.TabIndex = 12;
            this.lblAktif.Text = "Aktif Cihaz";
            // 
            // pnlAktif
            // 
            this.pnlAktif.BackColor = System.Drawing.Color.Linen;
            this.pnlAktif.BorderColor = System.Drawing.Color.Transparent;
            this.pnlAktif.Controls.Add(this.lblAktif);
            this.pnlAktif.Controls.Add(this.lblAktifCihaz);
            this.pnlAktif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlAktif.ForeColor = System.Drawing.Color.White;
            this.pnlAktif.Location = new System.Drawing.Point(237, 131);
            this.pnlAktif.Name = "pnlAktif";
            this.pnlAktif.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAktif.ShowText = true;
            this.pnlAktif.Size = new System.Drawing.Size(134, 100);
            this.pnlAktif.TabIndex = 12;
            // 
            // pnlPasif
            // 
            this.pnlPasif.BackColor = System.Drawing.Color.Linen;
            this.pnlPasif.BorderColor = System.Drawing.Color.Transparent;
            this.pnlPasif.Controls.Add(this.lblPasif);
            this.pnlPasif.Controls.Add(this.lblPasifCihaz);
            this.pnlPasif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlPasif.ForeColor = System.Drawing.Color.White;
            this.pnlPasif.Location = new System.Drawing.Point(74, 253);
            this.pnlPasif.Name = "pnlPasif";
            this.pnlPasif.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPasif.ShowText = true;
            this.pnlPasif.Size = new System.Drawing.Size(134, 100);
            this.pnlPasif.TabIndex = 12;
            // 
            // pnlBil
            // 
            this.pnlBil.BackColor = System.Drawing.Color.Linen;
            this.pnlBil.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBil.Controls.Add(this.lblBil);
            this.pnlBil.Controls.Add(this.lblBilinmeyenCihaz);
            this.pnlBil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlBil.ForeColor = System.Drawing.Color.White;
            this.pnlBil.Location = new System.Drawing.Point(237, 253);
            this.pnlBil.Name = "pnlBil";
            this.pnlBil.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBil.ShowText = true;
            this.pnlBil.Size = new System.Drawing.Size(134, 100);
            this.pnlBil.TabIndex = 12;
            // 
            // pnlServisDurum
            // 
            this.pnlServisDurum.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlServisDurum.BorderColor = System.Drawing.Color.Transparent;
            this.pnlServisDurum.Controls.Add(this.lblServisDurum);
            this.pnlServisDurum.Controls.Add(this.lblSonKontrol);
            this.pnlServisDurum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlServisDurum.ForeColor = System.Drawing.Color.White;
            this.pnlServisDurum.Location = new System.Drawing.Point(74, 379);
            this.pnlServisDurum.Name = "pnlServisDurum";
            this.pnlServisDurum.Padding = new System.Windows.Forms.Padding(5);
            this.pnlServisDurum.ShowText = true;
            this.pnlServisDurum.Size = new System.Drawing.Size(297, 83);
            this.pnlServisDurum.TabIndex = 14;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel1.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel1.Location = new System.Drawing.Point(304, 22);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(289, 59);
            this.headerLabel1.TabIndex = 15;
            this.headerLabel1.Text = "Dashboard";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 595);
            this.Controls.Add(this.headerLabel1);
            this.Controls.Add(this.pnlServisDurum);
            this.Controls.Add(this.pnlBil);
            this.Controls.Add(this.pnlPasif);
            this.Controls.Add(this.pnlAktif);
            this.Controls.Add(this.pnlToplam);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.chartDurum);
            this.Controls.Add(this.lblSonIslem);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDurum)).EndInit();
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
        private System.Windows.Forms.Label lblSonIslem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDurum;
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
    }
}