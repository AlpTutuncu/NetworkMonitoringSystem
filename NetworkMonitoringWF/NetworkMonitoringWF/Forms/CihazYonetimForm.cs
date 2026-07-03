using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkMonitoringWF.Models;

namespace NetworkMonitoringWF
{
    public partial class CihazYonetimForm : Form
    {
        private readonly HttpClient client = new HttpClient();
        private string kullaniciRol;

        public CihazYonetimForm(string rol)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            kullaniciRol = rol;

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private async void CihazYonetimForm_Load(object sender, EventArgs e)
        {
            CihazEkleButonunuAyarla();
            await CihazListele();
        }

        private void CihazEkleButonunuAyarla()
        {
            btnCihazEkle.BackColor = ColorTranslator.FromHtml("#97de8c");
            btnCihazEkle.ForeColor = ColorTranslator.FromHtml("#000000");
            btnCihazEkle.FlatStyle = FlatStyle.Flat;
            btnCihazEkle.FlatAppearance.BorderSize = 1;
        }

        private async Task CihazListele()
        {
            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Cihaz/CihazListele");

                List<CihazModel> cihazlar =
                    JsonConvert.DeserializeObject<List<CihazModel>>(json);

                GridiDoldur(cihazlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cihazlar listelenemedi: " + ex.Message);
            }
        }

        private void GridiDoldur(List<CihazModel> cihazlar)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cihazlar;

            GridGenelAyarlar();
            KolonBasliklariniAyarla();
            ButonKolonlariEkle();
            KolonSirasiAyarla();
            ButonRenkleriniAyarla();
            KolonGenislikleriniAyarla();
            RolYetkileriniUygula();
        }

        private void GridGenelAyarlar()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.RowTemplate.Height = 38;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 38;
            }
        }

        private void KolonBasliklariniAyarla()
        {
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].Visible = true;
                dataGridView1.Columns["Id"].HeaderText = "ID";
            }

            if (dataGridView1.Columns.Contains("VlanId"))
                dataGridView1.Columns["VlanId"].Visible = false;

            if (dataGridView1.Columns.Contains("CihazAdi"))
                dataGridView1.Columns["CihazAdi"].HeaderText = "Cihaz Adı";

            if (dataGridView1.Columns.Contains("IPAdresi"))
                dataGridView1.Columns["IPAdresi"].HeaderText = "IP Adresi";

            if (dataGridView1.Columns.Contains("CihazTipi"))
                dataGridView1.Columns["CihazTipi"].HeaderText = "Cihaz Tipi";

            if (dataGridView1.Columns.Contains("Konum"))
                dataGridView1.Columns["Konum"].HeaderText = "Konum";

            if (dataGridView1.Columns.Contains("Durum"))
                dataGridView1.Columns["Durum"].HeaderText = "Durum";

            if (dataGridView1.Columns.Contains("VlanBilgi"))
                dataGridView1.Columns["VlanBilgi"].HeaderText = "VLAN";
        }

        private void ButonKolonlariEkle()
        {
            if (!dataGridView1.Columns.Contains("Ping"))
            {
                DataGridViewButtonColumn pingBtn = new DataGridViewButtonColumn();

                pingBtn.FlatStyle = FlatStyle.Flat;
                pingBtn.DefaultCellStyle.ForeColor = Color.Black;
                pingBtn.Name = "Ping";
                pingBtn.HeaderText = "Ping";
                pingBtn.Text = "Ping";
                pingBtn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(pingBtn);
            }

            if (!dataGridView1.Columns.Contains("Guncelle"))
            {
                DataGridViewButtonColumn guncelleBtn = new DataGridViewButtonColumn();

                guncelleBtn.FlatStyle = FlatStyle.Flat;
                guncelleBtn.DefaultCellStyle.ForeColor = Color.Black;
                guncelleBtn.Name = "Guncelle";
                guncelleBtn.HeaderText = "✏️";
                guncelleBtn.Text = "✏️";
                guncelleBtn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(guncelleBtn);
            }

            if (!dataGridView1.Columns.Contains("Sil"))
            {
                DataGridViewButtonColumn silBtn = new DataGridViewButtonColumn();

                silBtn.FlatStyle = FlatStyle.Flat;
                silBtn.DefaultCellStyle.ForeColor = Color.Black;
                silBtn.Name = "Sil";
                silBtn.HeaderText = "🗑️";
                silBtn.Text = "🗑️";
                silBtn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(silBtn);
            }
        }

        private void KolonGenislikleriniAyarla()
        {
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns["Id"].Width = 55;
            }

            if (dataGridView1.Columns.Contains("Durum"))
            {
                dataGridView1.Columns["Durum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns["Durum"].Width = 90;
            }

            if (dataGridView1.Columns.Contains("Ping"))
            {
                dataGridView1.Columns["Ping"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns["Ping"].Width = 70;
            }

            if (dataGridView1.Columns.Contains("Guncelle"))
            {
                dataGridView1.Columns["Guncelle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns["Guncelle"].Width = 55;
            }

            if (dataGridView1.Columns.Contains("Sil"))
            {
                dataGridView1.Columns["Sil"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns["Sil"].Width = 55;
            }
        }

        private void KolonSirasiAyarla()
        {
            int index = 0;

            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("CihazAdi"))
                dataGridView1.Columns["CihazAdi"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("IPAdresi"))
                dataGridView1.Columns["IPAdresi"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("CihazTipi"))
                dataGridView1.Columns["CihazTipi"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Konum"))
                dataGridView1.Columns["Konum"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Durum"))
                dataGridView1.Columns["Durum"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("VlanBilgi"))
                dataGridView1.Columns["VlanBilgi"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Ping"))
                dataGridView1.Columns["Ping"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Guncelle"))
                dataGridView1.Columns["Guncelle"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Sil"))
                dataGridView1.Columns["Sil"].DisplayIndex = index++;
        }

        private void ButonRenkleriniAyarla()
        {
            if (dataGridView1.Columns.Contains("Guncelle"))
            {
                dataGridView1.Columns["Guncelle"].DefaultCellStyle.BackColor = Color.LightBlue;
                dataGridView1.Columns["Guncelle"].DefaultCellStyle.ForeColor = Color.Black;
            }

            if (dataGridView1.Columns.Contains("Sil"))
            {
                dataGridView1.Columns["Sil"].DefaultCellStyle.BackColor = Color.LightCoral;
                dataGridView1.Columns["Sil"].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void RolYetkileriniUygula()
        {
            if (kullaniciRol == "Personel")
            {
                btnCihazEkle.Enabled = false;

                if (dataGridView1.Columns.Contains("Guncelle"))
                    dataGridView1.Columns["Guncelle"].Visible = false;

                if (dataGridView1.Columns.Contains("Sil"))
                    dataGridView1.Columns["Sil"].Visible = false;
            }
            else
            {
                btnCihazEkle.Enabled = true;

                if (dataGridView1.Columns.Contains("Guncelle"))
                    dataGridView1.Columns["Guncelle"].Visible = true;

                if (dataGridView1.Columns.Contains("Sil"))
                    dataGridView1.Columns["Sil"].Visible = true;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string kolonAdi = dataGridView1.Columns[e.ColumnIndex].Name;

            if (kolonAdi == "Ping")
            {
                await CihazaPingAt(e.RowIndex);
            }
            else if (kolonAdi == "Sil")
            {
                await CihazSil(e.RowIndex);
            }
            else if (kolonAdi == "Guncelle")
            {
                await CihazGuncelle(e.RowIndex);
            }
        }

        private async Task CihazaPingAt(int rowIndex)
        {
            int id = Convert.ToInt32(
                dataGridView1.Rows[rowIndex].Cells["Id"].Value);

            HttpResponseMessage response =
                await client.PostAsync(
                    "https://localhost:7181/api/Ping/TekPing/" + id,
                    null);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                PingSonucModel sonuc =
                    JsonConvert.DeserializeObject<PingSonucModel>(json);

                MessageBox.Show(
                    "Cihaz Adı: " + sonuc.CihazAdi +
                    "\nIP Adresi: " + sonuc.IpAdresi +
                    "\nDurum: " + sonuc.Durum +
                    "\nGecikme: " + sonuc.Gecikme + " ms",
                    "Ping Sonucu");

                await CihazListele();
            }
            else
            {
                MessageBox.Show("Ping işlemi başarısız.");
            }
        }

        private async Task CihazSil(int rowIndex)
        {
            int id = Convert.ToInt32(
                dataGridView1.Rows[rowIndex].Cells["Id"].Value);

            string cihazAdi =
                dataGridView1.Rows[rowIndex].Cells["CihazAdi"].Value.ToString();

            DialogResult cevap = MessageBox.Show(
                cihazAdi + " cihazını silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cevap != DialogResult.Yes)
                return;

            HttpResponseMessage response =
                await client.DeleteAsync(
                    "https://localhost:7181/api/Cihaz/CihazSil/" + id);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cihaz silindi.");
                await CihazListele();
            }
            else
            {
                string hata = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Cihaz silinemedi: " + hata);
            }
        }

        private async Task CihazGuncelle(int rowIndex)
        {
            int id = Convert.ToInt32(
                dataGridView1.Rows[rowIndex].Cells["Id"].Value);

            string cihazAdi =
                dataGridView1.Rows[rowIndex].Cells["CihazAdi"].Value.ToString();

            string ipAdresi =
                dataGridView1.Rows[rowIndex].Cells["IPAdresi"].Value.ToString();

            string cihazTipi =
                dataGridView1.Rows[rowIndex].Cells["CihazTipi"].Value.ToString();

            string konum =
                dataGridView1.Rows[rowIndex].Cells["Konum"].Value.ToString();

            int? vlanId = null;

            object vlanObj =
                dataGridView1.Rows[rowIndex].Cells["VlanId"].Value;

            if (vlanObj != null &&
                vlanObj != DBNull.Value &&
                vlanObj.ToString() != "")
            {
                vlanId = Convert.ToInt32(vlanObj);
            }

            CihazGuncelleForm form = new CihazGuncelleForm(
                id,
                cihazAdi,
                ipAdresi,
                cihazTipi,
                konum,
                vlanId);

            form.ShowDialog();

            await CihazListele();
        }

        private async void btnCihazEkle_Click(object sender, EventArgs e)
        {
            CihazEkleForm form = new CihazEkleForm();
            form.ShowDialog();

            await CihazListele();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            string kelime = txtAra.Text.Trim();

            if (string.IsNullOrEmpty(kelime))
            {
                await CihazListele();
                return;
            }

            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Cihaz/CihazAra/" +
                    Uri.EscapeDataString(kelime));

                List<CihazModel> cihazlar =
                    JsonConvert.DeserializeObject<List<CihazModel>>(json);

                GridiDoldur(cihazlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama işlemi başarısız: " + ex.Message);
            }
        }

        private async void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            await CihazListele();
        }
    }
}