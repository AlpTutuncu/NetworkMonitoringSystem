using NetworkMonitoringWF.Models;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace NetworkMonitoringWF.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await DashboardGetir();

            PanelleriYuvarlat();

            pnlToplam.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlToplam, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlAktif.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlAktif, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlPasif.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlPasif, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlBil.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlBil, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlServisDurum.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlServisDurum, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlGraph.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlGraph, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlGraph2.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlGraph2, 20, ColorTranslator.FromHtml("#FDBA74"), 1);
            pnlSon.Resize += (s, ev) => PanelKoseVeBorderAyarla(pnlSon, 20, ColorTranslator.FromHtml("#FDBA74"), 1);

        }

        //private void CihazTipiGrafikDoldur(DashboardModel model)
        //{
        //    chartCihazTipi.Series.Clear();
        //    chartCihazTipi.ChartAreas.Clear();
        //    chartCihazTipi.Titles.Clear();

        //    ChartArea alan = new ChartArea("CihazTipiChart");
        //    chartCihazTipi.ChartAreas.Add(alan);

        //    Series seri = new Series("Cihaz Tipleri");
        //    seri.ChartType = SeriesChartType.Bar;

        //    if (model.CihazTipDagilimi != null)
        //    {
        //        foreach (var item in model.CihazTipDagilimi)
        //        {
        //            int pointIndex = seri.Points.AddY(item.Adet);
        //            seri.Points[pointIndex].AxisLabel = item.CihazTipi;
        //            seri.Points[pointIndex].Label = item.Adet.ToString();
        //        }
        //    }

        //    chartCihazTipi.Series.Add(seri);
        //    chartCihazTipi.Titles.Add("Cihaz Tipine Göre Dağılım");

        //    chartCihazTipi.Legends.Clear();

        //    chartCihazTipi.ChartAreas[0].AxisX.Interval = 1;
        //    chartCihazTipi.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        //    chartCihazTipi.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        //}

        private void CihazTipiGrafikDoldur(DashboardModel model)
        {
            chartCihazTipi.Series.Clear();
            chartCihazTipi.ChartAreas.Clear();
            chartCihazTipi.Titles.Clear();
            chartCihazTipi.Legends.Clear();

            // ── Genel chart ──────────────────────────────────────────────
            chartCihazTipi.BackColor = Color.White;
            chartCihazTipi.BorderlineColor = Color.Transparent;
            chartCihazTipi.BorderlineDashStyle = ChartDashStyle.Solid;
            chartCihazTipi.BorderlineWidth = 0;
            chartCihazTipi.BorderSkin.SkinStyle = BorderSkinStyle.None;

            // ── ChartArea ────────────────────────────────────────────────
            var alan = new ChartArea("CihazTipiChart");

            alan.BackColor = Color.White;
            alan.BorderColor = Color.Transparent;
            alan.ShadowOffset = 0;

            alan.InnerPlotPosition.Auto = false;
            alan.InnerPlotPosition.X = 22;      // 2 → 22, sol tarafa cihaz adları için yer aç
            alan.InnerPlotPosition.Y = 2;
            alan.InnerPlotPosition.Width = 60;  // 72 → 60, genişliği azalt
            alan.InnerPlotPosition.Height = 92;

            // Y ekseni (cihaz adları)
            alan.AxisY.LabelStyle.Font = new Font("Segoe UI", 8.5f);
            alan.AxisY.LabelStyle.ForeColor = Color.FromArgb(100, 105, 125);
            alan.AxisY.LabelStyle.Interval = 1;   // bunu ekle — her etiketi göster
            alan.AxisY.LineColor = Color.Transparent;
            alan.AxisY.MajorGrid.Enabled = false;
            alan.AxisY.MajorTickMark.Enabled = false;

            // X ekseni (değer)
            alan.AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
            alan.AxisX.LabelStyle.ForeColor = Color.FromArgb(100, 105, 125);
            alan.AxisX.LineColor = Color.FromArgb(225, 227, 235);
            alan.AxisX.LineWidth = 1;
            alan.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 234, 230);
            alan.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            alan.AxisX.MajorGrid.LineWidth = 1;
            alan.AxisX.MajorTickMark.Enabled = false;
            alan.AxisX.Minimum = 0;
            alan.AxisX.Interval = 1;

            chartCihazTipi.ChartAreas.Add(alan);

            // ── Renk paleti ──────────────────────────────────────────────
            var renkler = new[]
            {
        Color.FromArgb(42,  120, 214),
        Color.FromArgb(74,  58,  167),
        Color.FromArgb(237, 161, 0),
        Color.FromArgb(27,  175, 122),
        Color.FromArgb(0,   131, 0),
        Color.FromArgb(227, 73,  72),
        Color.FromArgb(137, 135, 129),
    };

            // ── Seri ─────────────────────────────────────────────────────
            var seri = new Series("Cihaz Tipleri")
            {
                ChartType = SeriesChartType.Bar,
                BorderWidth = 0,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
            };
            seri["PointWidth"] = "0.55";

            if (model.CihazTipDagilimi != null)
            {
                int i = 0;
                foreach (var item in model.CihazTipDagilimi)
                {
                    int idx = seri.Points.AddXY(item.CihazTipi, item.Adet);
                    var p = seri.Points[idx];

                    if (item.CihazTipi == "Router")
                        p.Color = Color.FromArgb(42, 120, 214);
                    else if (item.CihazTipi == "Switch")
                        p.Color = Color.FromArgb(74, 58, 167);
                    else if (item.CihazTipi == "Server")
                        p.Color = Color.FromArgb(237, 161, 0);
                    else if (item.CihazTipi == "PC")
                        p.Color = Color.FromArgb(27, 175, 122);
                    else if (item.CihazTipi == "Access Point")
                        p.Color = Color.FromArgb(0, 131, 0);
                    else if (item.CihazTipi == "Kamera")
                        p.Color = Color.FromArgb(227, 73, 72);
                    else
                        p.Color = Color.FromArgb(137, 135, 129);

                    p.AxisLabel = item.CihazTipi;
                    p.Label = item.Adet.ToString();
                    p.LabelForeColor = Color.FromArgb(25, 27, 40);
                    p.LabelFormat = "";

                    i++;
                }
            }

            chartCihazTipi.Series.Add(seri);
        }

        private void PanelleriYuvarlat()
        {
            Color borderRenk = ColorTranslator.FromHtml("#ced0e0");

            PanelKoseVeBorderAyarla(pnlToplam, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlAktif, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlPasif, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlBil, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlServisDurum, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlGraph, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlGraph2, 20, borderRenk, 1);
            PanelKoseVeBorderAyarla(pnlSon, 20, borderRenk, 1);
        }

        private void ServisPaneliniGuncelle(bool servisAktifMi)
        {
            if (servisAktifMi)
            {
                pnlServisDurum.BackColor = Color.FromArgb(220, 248, 230);
                lblServisDurum.ForeColor = Color.FromArgb(39, 140, 70);
                lblServisDurum.Text = "Aktif";
            }
            else
            {
                pnlServisDurum.BackColor = Color.FromArgb(255, 225, 225);
                lblServisDurum.ForeColor = Color.FromArgb(180, 50, 50);
                lblServisDurum.Text = "Pasif";
            }

            PanelKoseYuvarlat(pnlServisDurum, 20);
        }

        private void PanelKoseVeBorderAyarla(Control panel, int radius, Color borderColor, int borderWidth)
{
    if (panel.Width <= 0 || panel.Height <= 0)
        return;

    GraphicsPath regionPath = new GraphicsPath();

    Rectangle regionRect = new Rectangle(0, 0, panel.Width, panel.Height);

    regionPath.AddArc(regionRect.X, regionRect.Y, radius, radius, 180, 90);
    regionPath.AddArc(regionRect.Right - radius, regionRect.Y, radius, radius, 270, 90);
    regionPath.AddArc(regionRect.Right - radius, regionRect.Bottom - radius, radius, radius, 0, 90);
    regionPath.AddArc(regionRect.X, regionRect.Bottom - radius, radius, radius, 90, 90);
    regionPath.CloseFigure();

    panel.Region = new Region(regionPath);

    panel.Paint += (s, e) =>
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle borderRect = new Rectangle(
            borderWidth / 2,
            borderWidth / 2,
            panel.Width - borderWidth - 1,
            panel.Height - borderWidth - 1);

        using (GraphicsPath borderPath = new GraphicsPath())
        {
            borderPath.AddArc(borderRect.X, borderRect.Y, radius, radius, 180, 90);
            borderPath.AddArc(borderRect.Right - radius, borderRect.Y, radius, radius, 270, 90);
            borderPath.AddArc(borderRect.Right - radius, borderRect.Bottom - radius, radius, radius, 0, 90);
            borderPath.AddArc(borderRect.X, borderRect.Bottom - radius, radius, radius, 90, 90);
            borderPath.CloseFigure();

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawPath(pen, borderPath);
            }
        }
    };

    panel.Invalidate();
}

        private void PanelKoseYuvarlat(Control panel, int radius)
        {
            if (panel.Width <= 0 || panel.Height <= 0)
                return;

            GraphicsPath path = new GraphicsPath();

            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private async Task DashboardGetir()
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Dashboard/Ozet");

                DashboardModel model =
                    JsonConvert.DeserializeObject<DashboardModel>(json);

                lblToplamCihaz.Text = "" + model.ToplamCihaz;
                lblAktifCihaz.Text = "" + model.AktifCihaz;
                lblPasifCihaz.Text = "" + model.PasifCihaz;
                lblBilinmeyenCihaz.Text = "" + model.BilinmeyenCihaz;

                ServisPaneliniGuncelle(model.PingServisAktifMi);

                lblSonKontrol.Text = "Son Kontrol: " + model.SonKontrolZamani;
                lblSonIslem.Text = "" + model.SonIslem;
                lblSonAlarm.Text = "" + model.SonAlarm;

                GrafikDoldur(model);
                CihazTipiGrafikDoldur(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard verileri alınamadı: " + ex.Message);
            }
        }

        private void GrafikDoldur(DashboardModel model)
        {
            chartDurum.Series.Clear();
            chartDurum.ChartAreas.Clear();

            chartDurum.ChartAreas.Add("DurumChart");

            Series seri = new Series("Cihaz Durumları");
            seri.ChartType = SeriesChartType.Pie;

            DataPoint aktif = new DataPoint();
            aktif.SetValueY(model.AktifCihaz);
            aktif.LegendText = "Aktif";
            aktif.Label = "Aktif";

            DataPoint pasif = new DataPoint();
            pasif.SetValueY(model.PasifCihaz);
            pasif.LegendText = "Pasif";
            pasif.Label = "Pasif";

            if (model.BilinmeyenCihaz > 0)
            {
                DataPoint bilinmeyen = new DataPoint();
                bilinmeyen.SetValueY(model.BilinmeyenCihaz);
                bilinmeyen.LegendText = "Bilinmiyor";
                bilinmeyen.Label = "";

                seri.Points.Add(bilinmeyen);
            }

            seri.Points.Add(aktif);
            seri.Points.Add(pasif);

            chartDurum.Series.Add(seri);
            chartDurum.Titles.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Rapor/Ozet");

                RaporModel rapor =
                    JsonConvert.DeserializeObject<RaporModel>(json);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("NETWORK MONITORING RAPORU");
                sb.AppendLine("====================================");
                sb.AppendLine("Rapor Tarihi: " + rapor.RaporTarihi.ToString("dd.MM.yyyy HH:mm"));
                sb.AppendLine();

                sb.AppendLine("CİHAZ DURUM ÖZETİ");
                sb.AppendLine("------------------------------------");
                sb.AppendLine("Toplam Cihaz: " + rapor.ToplamCihaz);
                sb.AppendLine("Aktif Cihaz: " + rapor.AktifCihaz);
                sb.AppendLine("Pasif Cihaz: " + rapor.PasifCihaz);
                sb.AppendLine("Bilinmeyen Cihaz: " + rapor.BilinmeyenCihaz);
                sb.AppendLine();

                sb.AppendLine("VLAN ÖZETİ");
                sb.AppendLine("------------------------------------");
                sb.AppendLine("Toplam VLAN: " + rapor.ToplamVlan);
                sb.AppendLine();

                sb.AppendLine("SON ALARMLAR");
                sb.AppendLine("------------------------------------");

                if (rapor.SonAlarmlar != null && rapor.SonAlarmlar.Count > 0)
                {
                    foreach (string alarm in rapor.SonAlarmlar)
                        sb.AppendLine("- " + alarm);
                }
                else
                {
                    sb.AppendLine("- Kayıt bulunamadı.");
                }

                sb.AppendLine();

                sb.AppendLine("SON İŞLEMLER");
                sb.AppendLine("------------------------------------");

                if (rapor.SonIslemler != null && rapor.SonIslemler.Count > 0)
                {
                    foreach (string islem in rapor.SonIslemler)
                        sb.AppendLine("- " + islem);
                }
                else
                {
                    sb.AppendLine("- Kayıt bulunamadı.");
                }

                sb.AppendLine();

                sb.AppendLine("SON PING KAYITLARI");
                sb.AppendLine("------------------------------------");

                if (rapor.SonPingler != null && rapor.SonPingler.Count > 0)
                {
                    foreach (string ping in rapor.SonPingler)
                        sb.AppendLine("- " + ping);
                }
                else
                {
                    sb.AppendLine("- Kayıt bulunamadı.");
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası (*.txt)|*.txt";
                save.Title = "Raporu Kaydet";
                save.FileName = "NetworkReport_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Rapor başarıyla oluşturuldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken hata oluştu: " + ex.Message);
            }
        }

        private void lblServisDurum_Click(object sender, EventArgs e)
        {

        }
    }
}