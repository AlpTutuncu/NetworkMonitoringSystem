using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class VlanEkleForm : Form
    {
        public VlanEkleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VlanEkleForm_Load(object sender, EventArgs e)
        {
            cmbKonum.Items.Clear();

            cmbKonum.Items.Add("İzmir Ofis");
            cmbKonum.Items.Add("Ankara Ofis");
            cmbKonum.Items.Add("İstanbul Ofis");
            cmbKonum.Items.Add("Dış Ağ");

            cmbKonum.SelectedIndex = 0;

            pnlRenk.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void pnlRenk_Click(object sender, EventArgs e)
        {
            ColorDialog renkSec = new ColorDialog();
            renkSec.Color = pnlRenk.BackColor;

            if (renkSec.ShowDialog() == DialogResult.OK)
            {
                pnlRenk.BackColor = renkSec.Color;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVlanNo.Text.Trim(), out int vlanNo))
            {
                MessageBox.Show("VLAN numarası sayısal olmalıdır.");
                return;
            }

            if (vlanNo < 1 || vlanNo > 4094)
            {
                MessageBox.Show("VLAN numarası 1-4094 arasında olmalıdır.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVlanAdi.Text))
            {
                MessageBox.Show("VLAN adı boş bırakılamaz.");
                return;
            }

            if (cmbKonum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen konum seçiniz.");
                return;
            }

            var vlan = new
            {
                VlanNo = vlanNo,
                VlanAdi = txtVlanAdi.Text.Trim(),
                Subnet = txtSubnet.Text.Trim(),
                Gateway = txtGateway.Text.Trim(),
                Konum = cmbKonum.SelectedItem.ToString(),
                Aciklama = txtAciklama.Text.Trim(),
                Renk = ColorTranslator.ToHtml(pnlRenk.BackColor)
            };

            string json = JsonConvert.SerializeObject(vlan);

            StringContent content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(
                "https://localhost:7181/api/Vlan/Ekle",
                content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("VLAN eklendi.");
                this.Close();
            }
            else
            {
                string hata = await response.Content.ReadAsStringAsync();
                MessageBox.Show("VLAN eklenemedi: " + hata);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}