using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            PanelKoseYuvarlat(pnlRenk, 30);

            pnlRenk.BackColor = Color.FromArgb(52, 152, 219);
        }

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void PanelKoseYuvarlat(Control panel, int radius)
        {
            if (panel.Width <= 0 || panel.Height <= 0) return;

            // radius panel boyutunu aşmasın
            radius = Math.Min(radius, Math.Min(panel.Width, panel.Height) / 2);

            using (GraphicsPath path = RoundedRect(panel.ClientRectangle, radius))
            {
                panel.Region = new Region(path);
            }

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path2 = RoundedRect(panel.ClientRectangle, radius))
                using (Pen pen = new Pen(panel.Parent?.BackColor ?? Color.White, 2))
                {
                    e.Graphics.DrawPath(pen, path2);
                }
            };
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