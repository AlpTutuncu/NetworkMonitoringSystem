using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF
{
    public partial class CihazGuncelleForm : Form
    {
        private readonly HttpClient client = new HttpClient();

        private int cihazId;
        private int? mevcutVlanId;

        public CihazGuncelleForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public CihazGuncelleForm(
            int id,
            string cihazAdi,
            string ipAdresi,
            string cihazTipi,
            string konum,
            int? vlanId)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            cihazId = id;
            mevcutVlanId = vlanId;

            txtCihazAdi.Text = cihazAdi;
            txtIPAdresi.Text = ipAdresi;
            txtCihazTipi.Text = cihazTipi;
            txtKonum.Text = konum;
        }

        private async void CihazGuncelleForm_Load(object sender, EventArgs e)
        {
            await VlanlariYukle();
        }

        private async Task VlanlariYukle()
        {
            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Vlan/Listele");

                List<VlanModel> vlanlar =
                    JsonConvert.DeserializeObject<List<VlanModel>>(json);

                vlanlar.Insert(0, new VlanModel
                {
                    Id = 0,
                    VlanNo = 0,
                    VlanAdi = "VLAN Seçilmedi",
                    Konum = ""
                });

                cmbVlan.DataSource = null;
                cmbVlan.DataSource = vlanlar;

                VlanSec(vlanlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VLAN bilgileri yüklenemedi: " + ex.Message);
            }
        }

        private void VlanSec(List<VlanModel> vlanlar)
        {
            if (mevcutVlanId != null)
            {
                foreach (VlanModel vlan in vlanlar)
                {
                    if (vlan.Id == mevcutVlanId.Value)
                    {
                        cmbVlan.SelectedItem = vlan;
                        return;
                    }
                }
            }

            if (cmbVlan.Items.Count > 0)
                cmbVlan.SelectedIndex = 0;
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!FormKontrolEt())
                return;

            try
            {
                VlanModel secilenVlan = cmbVlan.SelectedItem as VlanModel;

                int? secilenVlanId = null;

                if (secilenVlan != null && secilenVlan.Id != 0)
                {
                    secilenVlanId = secilenVlan.Id;
                }

                var cihaz = new
                {
                    Id = cihazId,
                    CihazAdi = txtCihazAdi.Text.Trim(),
                    IPAdresi = txtIPAdresi.Text.Trim(),
                    CihazTipi = txtCihazTipi.Text.Trim(),
                    Konum = txtKonum.Text.Trim(),
                    VlanId = secilenVlanId
                };

                string json = JsonConvert.SerializeObject(cihaz);

                StringContent content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PutAsync(
                    "https://localhost:7181/api/Cihaz/CihazGuncelle",
                    content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cihaz güncellendi.");
                    this.Close();
                }
                else
                {
                    string hata = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Cihaz güncellenemedi: " + hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cihaz güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private bool FormKontrolEt()
        {
            if (string.IsNullOrWhiteSpace(txtCihazAdi.Text))
            {
                MessageBox.Show("Cihaz adı boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIPAdresi.Text))
            {
                MessageBox.Show("IP adresi boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCihazTipi.Text))
            {
                MessageBox.Show("Cihaz tipi boş olamaz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKonum.Text))
            {
                MessageBox.Show("Konum boş olamaz.");
                return false;
            }

            return true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}