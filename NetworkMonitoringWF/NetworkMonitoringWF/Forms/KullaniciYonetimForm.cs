using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NetworkMonitoringWF.Forms
{
    public partial class KullaniciYonetimForm : Form
    {
        private int seciliKullaniciId = 0;
        private readonly HttpClient client = new HttpClient();

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

            PanelKoseVeBorderAyarla(pnlBilgiler, 20, ColorTranslator.FromHtml("#D1D5DB"), 1);

            await KullanicilariListele();
        }

        private void GridGenelAyarlar()
        {
            dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullanicilar.AllowUserToAddRows = false;
            dgvKullanicilar.ReadOnly = true;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.MultiSelect = false;
        }

        private void KolonlariAyarla()
        {
            if (dgvKullanicilar.Columns.Contains("Id"))
            {
                dgvKullanicilar.Columns["Id"].Visible = true;
                dgvKullanicilar.Columns["Id"].HeaderText = "ID";
                dgvKullanicilar.Columns["Id"].DisplayIndex = 0;
                dgvKullanicilar.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvKullanicilar.Columns["Id"].Width = 60;
            }

            if (dgvKullanicilar.Columns.Contains("KullaniciAdi"))
            {
                dgvKullanicilar.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
                dgvKullanicilar.Columns["KullaniciAdi"].DisplayIndex = 1;
            }

            if (dgvKullanicilar.Columns.Contains("Sifre"))
            {
                dgvKullanicilar.Columns["Sifre"].HeaderText = "Şifre";
                dgvKullanicilar.Columns["Sifre"].DisplayIndex = 2;
            }

            if (dgvKullanicilar.Columns.Contains("Rol"))
            {
                dgvKullanicilar.Columns["Rol"].HeaderText = "Rol";
                dgvKullanicilar.Columns["Rol"].DisplayIndex = 3;
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

            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen rol seçiniz.");
                return false;
            }

            return true;
        }

        private void PanelKoseVeBorderAyarla(Control panel, int radius, Color borderColor, int borderWidth)
        {
            if (panel.Width <= 0 || panel.Height <= 0)
                return;

            using (GraphicsPath regionPath = new GraphicsPath())
            {
                Rectangle regionRect = new Rectangle(0, 0, panel.Width, panel.Height);

                regionPath.AddArc(regionRect.X, regionRect.Y, radius, radius, 180, 90);
                regionPath.AddArc(regionRect.Right - radius, regionRect.Y, radius, radius, 270, 90);
                regionPath.AddArc(regionRect.Right - radius, regionRect.Bottom - radius, radius, radius, 0, 90);
                regionPath.AddArc(regionRect.X, regionRect.Bottom - radius, radius, radius, 90, 90);
                regionPath.CloseFigure();

                panel.Region = new Region(regionPath);
            }

            panel.Tag = new Tuple<int, Color, int>(radius, borderColor, borderWidth);

            panel.Paint -= PanelBorderPaint;
            panel.Paint += PanelBorderPaint;

            panel.Invalidate();
        }

        private void PanelBorderPaint(object sender, PaintEventArgs e)
        {
            Control panel = sender as Control;

            if (panel == null || panel.Tag == null)
                return;

            Tuple<int, Color, int> ayar = panel.Tag as Tuple<int, Color, int>;

            if (ayar == null)
                return;

            int radius = ayar.Item1;
            Color borderColor = ayar.Item2;
            int borderWidth = ayar.Item3;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle borderRect = new Rectangle(
                borderWidth,
                borderWidth,
                panel.Width - borderWidth * 2 - 1,
                panel.Height - borderWidth * 2 - 1);

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
        }

        private async Task KullanicilariListele()
        {
            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Kullanici/Listele");

                List<KullaniciModel> kullanicilar =
                    JsonConvert.DeserializeObject<List<KullaniciModel>>(json);

                dgvKullanicilar.DataSource = null;
                dgvKullanicilar.DataSource = kullanicilar;

                GridGenelAyarlar();
                KolonlariAyarla();
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
            if (!FormKontrolEt())
                return;

            try
            {
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

            if (!FormKontrolEt())
                return;

            try
            {
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