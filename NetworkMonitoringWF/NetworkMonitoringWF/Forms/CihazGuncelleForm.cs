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
        private int cihazId;
        private int? mevcutVlanId;

        public CihazGuncelleForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            HttpClient client = new HttpClient();

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

            // Mevcut VLAN seçili gelsin
            if (mevcutVlanId != null)
            {
                foreach (VlanModel vlan in vlanlar)
                {
                    if (vlan.Id == mevcutVlanId.Value)
                    {
                        cmbVlan.SelectedItem = vlan;
                        break;
                    }
                }
            }
            else
            {
                cmbVlan.SelectedIndex = 0;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}