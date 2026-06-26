using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using NetworkMonitoringWF.Models;

namespace NetworkMonitoringWF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            txtKullaniciAdi.KeyDown += LoginEnter_KeyDown;
            txtSifre.KeyDown += LoginEnter_KeyDown;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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
        
            HttpClient client = new HttpClient();

            var loginData = new
            {
                KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                Sifre = txtSifre.Text.Trim()
            };

            string json =
                JsonConvert.SerializeObject(loginData);

            StringContent content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

            HttpResponseMessage response =
                await client.PostAsync(
                    "https://localhost:7181/api/Auth/Login",
                    content);

            if (response.IsSuccessStatusCode)
            {
                string result =
                    await response.Content.ReadAsStringAsync();

                LoginResponse user =
                    JsonConvert.DeserializeObject<LoginResponse>(result);

                AnaSayfaForm anaSayfa = new AnaSayfaForm(user.KullaniciAdi, user.Rol);
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
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
    }
}
