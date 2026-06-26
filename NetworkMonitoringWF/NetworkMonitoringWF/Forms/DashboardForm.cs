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

            pnlToplam.Resize += (s, ev) => PanelKoseYuvarlat(pnlToplam, 20);
            pnlAktif.Resize += (s, ev) => PanelKoseYuvarlat(pnlAktif, 20);
            pnlPasif.Resize += (s, ev) => PanelKoseYuvarlat(pnlPasif, 20);
            pnlBil.Resize += (s, ev) => PanelKoseYuvarlat(pnlBil, 20);
            pnlServisDurum.Resize += (s, ev) => PanelKoseYuvarlat(pnlServisDurum, 20);
        }

        private void PanelleriYuvarlat()
        {
            PanelKoseYuvarlat(pnlToplam, 20);
            PanelKoseYuvarlat(pnlAktif, 20);
            PanelKoseYuvarlat(pnlPasif, 20);
            PanelKoseYuvarlat(pnlBil, 20);
            PanelKoseYuvarlat(pnlServisDurum, 20);
        }

        private void ServisPaneliniGuncelle(bool servisAktifMi)
        {
            if (servisAktifMi)
            {
                pnlServisDurum.BackColor = Color.FromArgb(220, 248, 230);
                lblServisDurum.ForeColor = Color.FromArgb(39, 140, 70);
                lblServisDurum.Text = "Ping Servisi: Aktif";
            }
            else
            {
                pnlServisDurum.BackColor = Color.FromArgb(255, 225, 225);
                lblServisDurum.ForeColor = Color.FromArgb(180, 50, 50);
                lblServisDurum.Text = "Ping Servisi: Pasif";
            }

            PanelKoseYuvarlat(pnlServisDurum, 20);
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
                lblSonIslem.Text = "Son İşlem: " + model.SonIslem;

                GrafikDoldur(model);
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
            chartDurum.Titles.Add("Aktif / Pasif Cihaz Dağılımı");
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