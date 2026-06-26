using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class KullaniciYonetimForm : Form
    {
        private int seciliKullaniciId = 0;

        public KullaniciYonetimForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void KullaniciYonetimForm_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Personel");
            cmbRol.SelectedIndex = 1;

            await KullanicilariListele();
        }

        private async Task KullanicilariListele()
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Kullanici/Listele");

                List<KullaniciModel> kullanicilar =
                    JsonConvert.DeserializeObject<List<KullaniciModel>>(json);

                dgvKullanicilar.DataSource = null;
                dgvKullanicilar.DataSource = kullanicilar;

                dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKullanicilar.AllowUserToAddRows = false;
                dgvKullanicilar.ReadOnly = true;
                dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKullanicilar.MultiSelect = false;

                if (dgvKullanicilar.Columns.Contains("Id"))
                    dgvKullanicilar.Columns["Id"].Visible = false;

                if (dgvKullanicilar.Columns.Contains("KullaniciAdi"))
                    dgvKullanicilar.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";

                if (dgvKullanicilar.Columns.Contains("Sifre"))
                    dgvKullanicilar.Columns["Sifre"].HeaderText = "Şifre";

                if (dgvKullanicilar.Columns.Contains("Rol"))
                    dgvKullanicilar.Columns["Rol"].HeaderText = "Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcılar listelenemedi: " + ex.Message);
            }
        }

        private void AlanlariTemizle()
        {
            seciliKullaniciId = 0;
            txtKullaniciAdi.Clear();
            txtSifre.Clear();

            if (cmbRol.Items.Count > 0)
                cmbRol.SelectedIndex = 1;

            dgvKullanicilar.ClearSelection();
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            seciliKullaniciId = Convert.ToInt32(
                dgvKullanicilar.Rows[e.RowIndex].Cells["Id"].Value);

            txtKullaniciAdi.Text =
                dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();

            txtSifre.Text =
                dgvKullanicilar.Rows[e.RowIndex].Cells["Sifre"].Value.ToString();

            cmbRol.SelectedItem =
                dgvKullanicilar.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş olamaz.");
                return;
            }

            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen rol seçiniz.");
                return;
            }

            try
            {
                HttpClient client = new HttpClient();

                var kullanici = new
                {
                    Id = 0,
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text.Trim(),
                    Rol = cmbRol.SelectedItem.ToString()
                };

                string json = JsonConvert.SerializeObject(kullanici);

                StringContent content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PostAsync(
                    "https://localhost:7181/api/Kullanici/Ekle",
                    content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kullanıcı eklendi.");
                    AlanlariTemizle();
                    await KullanicilariListele();
                }
                else
                {
                    string hata = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Kullanıcı eklenemedi: " + hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı ekleme hatası: " + ex.Message);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullaniciId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçiniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş olamaz.");
                return;
            }

            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen rol seçiniz.");
                return;
            }

            try
            {
                HttpClient client = new HttpClient();

                var kullanici = new
                {
                    Id = seciliKullaniciId,
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text.Trim(),
                    Rol = cmbRol.SelectedItem.ToString()
                };

                string json = JsonConvert.SerializeObject(kullanici);

                StringContent content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PutAsync(
                    "https://localhost:7181/api/Kullanici/Guncelle",
                    content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kullanıcı güncellendi.");
                    AlanlariTemizle();
                    await KullanicilariListele();
                }
                else
                {
                    string hata = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Kullanıcı güncellenemedi: " + hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncelleme hatası: " + ex.Message);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKullaniciId == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                txtKullaniciAdi.Text + " kullanıcısı silinsin mi?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cevap != DialogResult.Yes)
                return;

            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.DeleteAsync(
                    "https://localhost:7181/api/Kullanici/Sil/" + seciliKullaniciId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kullanıcı silindi.");
                    AlanlariTemizle();
                    await KullanicilariListele();
                }
                else
                {
                    string hata = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Kullanıcı silinemedi: " + hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silme hatası: " + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}