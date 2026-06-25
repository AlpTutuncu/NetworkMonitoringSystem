using NetworkMonitoringWF.Forms;
using NetworkMonitoringWF.Models;
using Newtonsoft.Json;
using System;
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

            this.kullaniciAdi = kullaniciAdi;
            this.kullaniciRol = kullaniciRol;

            alarmTimer.Interval = 10000; // 10 saniyede bir alarm kontrolü
            alarmTimer.Tick += async (s, e) => await AlarmKontrolEt();
            alarmTimer.Start();
        }

        private async void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoşgeldiniz " + kullaniciAdi;
            if (kullaniciRol == "Admin")
            {
                btnKullaniciYonetimi.Visible = true;
            }
            else
            {
                btnKullaniciYonetimi.Visible = false;
            }

            // Alarm panelinin görünümünü artık Designer'dan elle ayarlayacaksın.
            // Kod burada sadece başlangıçta gizliyor.
            pnlAlarm.Visible = false;

            await ServisDurumunuGetir();

            // Sayfa açılır açılmaz bir kere kontrol etsin.
            await AlarmKontrolEt();
        }

        private async Task AlarmKontrolEt()
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Alarm/SonOkunmamis");

                if (string.IsNullOrWhiteSpace(json) || json == "null")
                {
                    pnlAlarm.Visible = false;
                    aktifAlarm = null;
                    return;
                }

                aktifAlarm =
                    JsonConvert.DeserializeObject<AlarmBildirimModel>(json);

                lblAlarmMesaj.Text = "⚠ " + aktifAlarm.Mesaj;

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
            pnlAlarm.Visible = false;
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

        private void btnCihazYonetimi_Click(object sender, EventArgs e)
        {
            CihazYonetimForm form = new CihazYonetimForm(kullaniciRol);
            form.Show();
        }

        private void btnLoglar_Click(object sender, EventArgs e)
        {
            LogForm form = new LogForm();
            form.Show();
        }

        private async Task ServisDurumunuGetir()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Ping/Durum");

            if (json.Contains("true"))
            {
                lblServisDurum.Text = "Ping Servisi: Aktif";
                btnServisBaslat.Enabled = false;
                btnServisDurdur.Enabled = true;
            }
            else
            {
                lblServisDurum.Text = "Ping Servisi: Pasif";
                btnServisBaslat.Enabled = true;
                btnServisDurdur.Enabled = false;
            }
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
        }

        private void btnTopoloji_Click(object sender, EventArgs e)
        {
            TopolojiForm form = new TopolojiForm();
            form.Show();
        }

        private void btnPingLog_Click(object sender, EventArgs e)
        {
            PingLogForm form = new PingLogForm();
            form.Show();
        }

        private void btnVlanYonetimi_Click(object sender, EventArgs e)
        {
            VlanYonetimForm form = new VlanYonetimForm();
            form.Show();
        }

        private void lblAlarmMesaj_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimForm form = new KullaniciYonetimForm();
            form.Show();
        }
    }
}