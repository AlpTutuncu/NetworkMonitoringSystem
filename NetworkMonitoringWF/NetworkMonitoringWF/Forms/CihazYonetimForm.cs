using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkMonitoringWF.Models;


namespace NetworkMonitoringWF
{
    public partial class CihazYonetimForm : Form
    {
        private string kullaniciRol;

        public CihazYonetimForm(string rol)
        {
            InitializeComponent();
            kullaniciRol = rol;
        }
        private async void CihazYonetimForm_Load(object sender, EventArgs e)
        {
            await CihazListele();
            if (kullaniciRol == "Personel")
            {
                btnCihazEkle.Enabled = false;

                if (dataGridView1.Columns.Contains("Guncelle"))
                    dataGridView1.Columns["Guncelle"].Visible = false;

                if (dataGridView1.Columns.Contains("Sil"))
                    dataGridView1.Columns["Sil"].Visible = false;
            }
        }

        private async Task CihazListele()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Cihaz/CihazListele");

            List<CihazModel> cihazlar =
                JsonConvert.DeserializeObject<List<CihazModel>>(json);

            dataGridView1.DataSource = cihazlar;

            dataGridView1.Columns["VlanBilgi"].HeaderText = "VLAN";
            dataGridView1.Columns["CihazAdi"].HeaderText = "Cihaz Adı";
            dataGridView1.Columns["IPAdresi"].HeaderText = "IP Adresi";
            dataGridView1.Columns["CihazTipi"].HeaderText = "Cihaz Tipi";
            dataGridView1.Columns["VlanId"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            ButonKolonlariEkle();

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns["Ping"].DefaultCellStyle.BackColor = Color.LightGreen;

            dataGridView1.Columns["Guncelle"].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns["Sil"].DefaultCellStyle.BackColor = Color.LightCoral;
        }

        private void ButonKolonlariEkle()
        {
            if (!dataGridView1.Columns.Contains("Ping"))
            {
                DataGridViewButtonColumn pingBtn = new DataGridViewButtonColumn();

                pingBtn.FlatStyle = FlatStyle.Flat;
                pingBtn.DefaultCellStyle.BackColor = Color.LightGreen;
                pingBtn.DefaultCellStyle.ForeColor = Color.Black;

                pingBtn.Name = "Ping";
                pingBtn.HeaderText = "Ping";
                pingBtn.Text = "Ping At";
                pingBtn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(pingBtn);
            }

            if (!dataGridView1.Columns.Contains("Guncelle"))
            {
                DataGridViewButtonColumn guncelleBtn = new DataGridViewButtonColumn();

                guncelleBtn.FlatStyle = FlatStyle.Flat;
                guncelleBtn.DefaultCellStyle.BackColor = Color.LightBlue;
                guncelleBtn.DefaultCellStyle.ForeColor = Color.Black;

                guncelleBtn.Name = "Guncelle";
                guncelleBtn.HeaderText = "Güncelle";
                guncelleBtn.Text = "Güncelle";
                guncelleBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(guncelleBtn);
            }

            if (!dataGridView1.Columns.Contains("Sil"))
            {
                DataGridViewButtonColumn silBtn = new DataGridViewButtonColumn();

                silBtn.FlatStyle = FlatStyle.Flat;
                silBtn.DefaultCellStyle.BackColor = Color.LightCoral;
                silBtn.DefaultCellStyle.ForeColor = Color.Black;

                silBtn.Name = "Sil";
                silBtn.HeaderText = "Sil";
                silBtn.Text = "Sil";
                silBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(silBtn);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ping")
            {
                int id = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                HttpClient client = new HttpClient();

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

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string cihazAdi = dataGridView1.Rows[e.RowIndex].Cells["CihazAdi"].Value.ToString();

                DialogResult cevap = MessageBox.Show(
                    cihazAdi + " cihazını silmek istiyor musunuz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    HttpClient client = new HttpClient();

                    HttpResponseMessage response =
                        await client.DeleteAsync("https://localhost:7181/api/Cihaz/CihazSil/" + id);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cihaz silindi.");
                        await CihazListele();
                    }
                    else
                    {
                        MessageBox.Show("Cihaz silinemedi.");
                    }
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Guncelle")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string cihazAdi = dataGridView1.Rows[e.RowIndex].Cells["CihazAdi"].Value.ToString();
                string ipAdresi = dataGridView1.Rows[e.RowIndex].Cells["IPAdresi"].Value.ToString();
                string cihazTipi = dataGridView1.Rows[e.RowIndex].Cells["CihazTipi"].Value.ToString();
                string konum = dataGridView1.Rows[e.RowIndex].Cells["Konum"].Value.ToString();

                int? vlanId = null;

                object vlanObj = dataGridView1.Rows[e.RowIndex].Cells["VlanId"].Value;

                if (vlanObj != null && vlanObj != DBNull.Value && vlanObj.ToString() != "")
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

            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Cihaz/CihazAra/" + kelime);

            List<CihazModel> cihazlar =
                JsonConvert.DeserializeObject<List<CihazModel>>(json);

            dataGridView1.DataSource = cihazlar;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            ButonKolonlariEkle();
        }

        private async void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            await CihazListele();
        }
    }

}
