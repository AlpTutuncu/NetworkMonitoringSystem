using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace NetworkMonitoringWF
{
    public partial class CihazEkleForm : Form
    {
        public CihazEkleForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void CihazEkleForm_Load(object sender, EventArgs e)
        {
            await VlanlariYukle();
        }

        private async System.Threading.Tasks.Task VlanlariYukle()
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

            cmbVlan.DataSource = vlanlar;
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

            HttpResponseMessage response = await client.PostAsync(
                "https://localhost:7181/api/Cihaz/CihazEkle",
                content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cihaz eklendi.");
                this.Close();
            }
            else
            {
                string hata = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Cihaz eklenemedi: " + hata);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}