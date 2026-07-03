using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace NetworkMonitoringWF
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient client = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            txtKullaniciAdi.KeyDown += LoginEnter_KeyDown;
            txtSifre.KeyDown += LoginEnter_KeyDown;
        }

        private void LoginEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris_Click(btnGiris, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            if (!FormKontrolEt())
                return;

            try
            {
                var loginData = new
                {
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text.Trim()
                };

                string json = JsonConvert.SerializeObject(loginData);

                StringContent content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PostAsync(
                    "https://localhost:7181/api/Auth/Login",
                    content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    LoginResponse user =
                        JsonConvert.DeserializeObject<LoginResponse>(result);

                    AnaSayfaForm anaSayfa =
                        new AnaSayfaForm(user.KullaniciAdi, user.Rol);

                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        private bool FormKontrolEt()
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş olamaz.");
                return false;
            }

            return true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(
                "Uygulamadan çıkmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}