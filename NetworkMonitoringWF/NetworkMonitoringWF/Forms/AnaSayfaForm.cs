using NetworkMonitoringWF.Forms;
using NetworkMonitoringWF.Models;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF
{
    public partial class AnaSayfaForm : Form
    {
        private string kullaniciAdi;
        private string kullaniciRol;

        private AlarmBildirimModel aktifAlarm = null;
        private Timer alarmTimer = new Timer();

        public AnaSayfaForm(string kullaniciAdi, string kullaniciRol)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.kullaniciAdi = kullaniciAdi;
            this.kullaniciRol = kullaniciRol;

            alarmTimer.Interval = 10000; // 10 saniyede bir alarm kontrolü
            alarmTimer.Tick += async (s, e) => await AlarmKontrolEt();
            alarmTimer.Start();
        }

        private async void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            RolYetkileriniUygula();
            lblKullanici.Text = "" + kullaniciAdi;

            // Alarm panelinin görünümünü artık Designer'dan elle ayarlayacaksın.
            // Kod burada sadece başlangıçta gizliyor.
            pnlAlarm.Visible = false;

            await ServisDurumunuGetir();

            // Sayfa açılır açılmaz bir kere kontrol etsin.
            await AlarmKontrolEt();

            KartAyarla(pnlCihazYonetimi, pnlCihazYonetimi_Click);
            KartAyarla(pnlSistemKayitlari, pnlSistemKayitlari_Click);
            KartAyarla(pnlTopoloji, pnlTopoloji_Click);
            KartAyarla(pnlDashboard, pnlDashboard_Click);
            KartAyarla(pnlPingKayitlari, pnlPingKayitlari_Click);
            KartAyarla(pnlVlanYonetimi, pnlVlanYonetimi_Click);

            KartKoseVeBorderAyarla(
            pnlAlarm,
            18,
            ColorTranslator.FromHtml("#FF7F50"));
        }

        private void KartAyarla(Control kart, EventHandler clickEvent)
        {
            Color normal = ColorTranslator.FromHtml("#ffffff");
            Color hover = ColorTranslator.FromHtml("#edc6a6");
            Color click = ColorTranslator.FromHtml("#edc6a6");
            Color border = ColorTranslator.FromHtml("#FF7F50");

            KartHoverAyarla(kart, normal, hover, click);
            KartKoseVeBorderAyarla(kart, 18, border);
            KartClickAyarla(kart, clickEvent);
        }

        private void KartKoseVeBorderAyarla(Control kart, int radius, Color borderColor)
        {
            if (kart.Width <= 0 || kart.Height <= 0)
                return;

            GraphicsPath path = new GraphicsPath();

            Rectangle rect = new Rectangle(0, 0, kart.Width, kart.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            kart.Region = new Region(path);

            kart.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (GraphicsPath borderPath = new GraphicsPath())
                {
                    Rectangle borderRect = new Rectangle(0, 0, kart.Width - 1, kart.Height - 1);

                    borderPath.AddArc(borderRect.X, borderRect.Y, radius, radius, 180, 90);
                    borderPath.AddArc(borderRect.Right - radius, borderRect.Y, radius, radius, 270, 90);
                    borderPath.AddArc(borderRect.Right - radius, borderRect.Bottom - radius, radius, radius, 0, 90);
                    borderPath.AddArc(borderRect.X, borderRect.Bottom - radius, radius, radius, 90, 90);
                    borderPath.CloseFigure();

                    using (Pen pen = new Pen(borderColor, 1))
                    {
                        e.Graphics.DrawPath(pen, borderPath);
                    }
                }
            };

            kart.Invalidate();
        }

        private void FormAc(Form form)
        {
            this.Hide();

            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();

            this.Show();
        }

        private void KartHoverAyarla(Control kart, Color normalRenk, Color hoverRenk, Color tiklamaRenk)
        {
            kart.Cursor = Cursors.Hand;
            kart.BackColor = normalRenk;

            Timer hoverTimer = new Timer();
            hoverTimer.Interval = 100;

            hoverTimer.Tick += (s, e) =>
            {
                Point mouseKonumu = kart.PointToClient(Cursor.Position);

                if (!kart.ClientRectangle.Contains(mouseKonumu))
                {
                    kart.BackColor = normalRenk;
                    hoverTimer.Stop();
                }
            };

            void HoverYap()
            {
                kart.BackColor = hoverRenk;

                if (!hoverTimer.Enabled)
                    hoverTimer.Start();
            }

            void TiklamaYap()
            {
                kart.BackColor = tiklamaRenk;
            }

            kart.MouseMove += (s, e) => HoverYap();
            kart.MouseEnter += (s, e) => HoverYap();
            kart.MouseDown += (s, e) => TiklamaYap();
            kart.MouseUp += (s, e) => HoverYap();

            foreach (Control control in kart.Controls)
            {
                control.Cursor = Cursors.Hand;

                control.MouseMove += (s, e) => HoverYap();
                control.MouseEnter += (s, e) => HoverYap();
                control.MouseDown += (s, e) => TiklamaYap();
                control.MouseUp += (s, e) => HoverYap();
            }
        }

        private void RolYetkileriniUygula()
        {
            if (kullaniciRol == "Admin")
            {
                btnKullaniciYonetimi.Visible = true;

                btnServisBaslat.Visible = true;
                btnServisDurdur.Visible = true;

                btnServisBaslat.Enabled = true;
                btnServisDurdur.Enabled = true;
            }
            else if (kullaniciRol == "Personel")
            {
                btnKullaniciYonetimi.Visible = false;

                btnServisBaslat.Visible = true;
                btnServisDurdur.Visible = true;

                btnServisBaslat.Enabled = false;
                btnServisDurdur.Enabled = false;
            }
        }

        private async Task AlarmKontrolEt()
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Alarm/SonOkunmamis");

                // Alarm yoksa
                if (string.IsNullOrWhiteSpace(json) || json == "null")
                {
                    aktifAlarm = null;

                    lblAlarmMesaj.Text = "✅ Bildirim yok";
                    lblAlarmMesaj.ForeColor = ColorTranslator.FromHtml("#166534");
                    pnlAlarm.BackColor = ColorTranslator.FromHtml("#ffffff");

                    btnAlarmKapat.Visible = false;

                    pnlAlarm.Visible = true;
                    pnlAlarm.BringToFront();

                    return;
                }

                // Alarm varsa
                aktifAlarm =
                    JsonConvert.DeserializeObject<AlarmBildirimModel>(json);

                lblAlarmMesaj.Text = "⚠ " + aktifAlarm.Mesaj;
                pnlAlarm.BackColor = ColorTranslator.FromHtml("#FFF1ED");

                btnAlarmKapat.Visible = true;

                pnlAlarm.Visible = true;
                pnlAlarm.BringToFront();
            }
            catch
            {
                // Ana sayfada sürekli hata göstermeyelim.
            }
        }

        private async Task AlarmiKapat()
        {
            if (aktifAlarm == null)
                return;

            HttpClient client = new HttpClient();

            await client.PutAsync(
                "https://localhost:7181/api/Alarm/Okundu/" + aktifAlarm.Id,
                null);

            aktifAlarm = null;

            lblAlarmMesaj.Text = "✅ Bildirim yok";
            lblAlarmMesaj.ForeColor = ColorTranslator.FromHtml("#166534");
            pnlAlarm.BackColor = ColorTranslator.FromHtml("#ffffff");

            btnAlarmKapat.Visible = false;
            pnlAlarm.Visible = true;
        }

        private async void btnAlarmKapat_Click(object sender, EventArgs e)
        {
            await AlarmiKapat();
        }

        private async void btnCikis_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var logoutData = new
            {
                KullaniciAdi = kullaniciAdi
            };

            string json =
                JsonConvert.SerializeObject(logoutData);

            StringContent content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

            await client.PostAsync(
                "https://localhost:7181/api/Auth/Logout",
                content);

            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }

        private async Task ServisDurumunuGetir()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Ping/Durum");

            bool servisAktifMi = json.Contains("true");

            if (servisAktifMi)
            {
                lblServisDurum.Text = "Aktif";

                pnlPingServisDurum.BackColor = ColorTranslator.FromHtml("#ECFDF5"); // açık yeşil
                lblServisDurum.ForeColor = ColorTranslator.FromHtml("#166534");     // koyu yeşil

                if (kullaniciRol == "Admin")
                {
                    btnServisBaslat.Enabled = false;
                    btnServisDurdur.Enabled = true;
                }
            }
            else
            {
                lblServisDurum.Text = "Pasif";

                pnlPingServisDurum.BackColor = ColorTranslator.FromHtml("#FEF2F2"); // açık kırmızı
                lblServisDurum.ForeColor = ColorTranslator.FromHtml("#991B1B");     // koyu kırmızı

                if (kullaniciRol == "Admin")
                {
                    btnServisBaslat.Enabled = true;
                    btnServisDurdur.Enabled = false;
                }
            }

            if (kullaniciRol == "Personel")
            {
                btnServisBaslat.Enabled = false;
                btnServisDurdur.Enabled = false;
            }

            btnServisBaslat.BackColor = Color.White;
            btnServisDurdur.BackColor = Color.White;

            btnServisBaslat.ForeColor = Color.FromArgb(60, 60, 60);
            btnServisDurdur.ForeColor = Color.FromArgb(60, 60, 60);
        }

        private async void btnServisBaslat_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            await client.PostAsync(
                "https://localhost:7181/api/Ping/Baslat",
                null);

            await ServisDurumunuGetir();
        }

        private async void btnServisDurdur_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            await client.PostAsync(
                "https://localhost:7181/api/Ping/Durdur",
                null);

            await ServisDurumunuGetir();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            FormAc(new KullaniciYonetimForm());
        }

        private void pnlCihazYonetimi_Click(object sender, EventArgs e)
        {
            FormAc(new CihazYonetimForm(kullaniciRol));
        }

        private void pnlSistemKayitlari_Click(object sender, EventArgs e)
        {
            FormAc(new LogForm());
        }

        private void KartClickAyarla(Control kart, EventHandler clickEvent)
        {
            kart.Click += clickEvent;
            kart.Cursor = Cursors.Hand;

            foreach (Control control in kart.Controls)
            {
                control.Click += clickEvent;
                control.Cursor = Cursors.Hand;
            }
        }

        private void pnlTopoloji_Click(object sender, EventArgs e)
        {
            FormAc(new TopolojiForm(kullaniciRol));
        } 

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            FormAc(new DashboardForm());
        }

        private void pnlPingKayitlari_Click(object sender, EventArgs e)
        {
            FormAc(new PingLogForm());
        }

        private void pnlVlanYonetimi_Click(object sender, EventArgs e)
        {
            FormAc(new VlanYonetimForm(kullaniciRol));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            alarmTimer.Stop();
            alarmTimer.Dispose();
            base.OnFormClosing(e);
        }

    }
}