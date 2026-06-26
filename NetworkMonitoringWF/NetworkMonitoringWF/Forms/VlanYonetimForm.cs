using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class VlanYonetimForm : Form
    {
        private List<VlanModel> vlanListesi = new List<VlanModel>();
        private VlanModel seciliVlan = null;
        private string kullaniciRol;

        public VlanYonetimForm(string rol)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "VLAN Yönetimi";
            kullaniciRol = rol;
        }

        public VlanYonetimForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            kullaniciRol = "Admin";
        }

        private void RolYetkileriniUygula()
        {
            if (kullaniciRol == "Admin")
            {
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else if (kullaniciRol == "Personel")
            {
                btnEkle.Enabled = false;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void ButonStili(Button btn, Color arkaplan, Color yazi)
        {
            btn.BackColor = arkaplan;
            btn.ForeColor = yazi;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(arkaplan, 0.15f);
            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(arkaplan, 0.1f);
            btn.Font = new Font("Segoe UI Semibold", 9f);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        private void ButonlariStillendir()
        {
            ButonStili(btnEkle, Color.FromArgb(134, 239, 172), Color.Black);
            ButonStili(btnGuncelle, Color.FromArgb(147, 197, 253), Color.Black);
            ButonStili(btnSil, Color.FromArgb(252, 165, 165), Color.Black);
            
        }

        private async void VlanYonetimForm_Load(object sender, EventArgs e)
        {
            RolYetkileriniUygula();
            cmbKonum.Items.Clear();

            cmbKonum.Items.Add("İzmir Ofis");
            cmbKonum.Items.Add("Ankara Ofis");
            cmbKonum.Items.Add("İstanbul Ofis");
            cmbKonum.Items.Add("Dış Ağ");

            cmbKonum.SelectedIndex = 0;
            PnlIstatistikStili();
            ButonlariStillendir();

            await VlanlariGetir();
        }

        private async Task VlanlariGetir()
        {
            if (cmbKonum.SelectedItem == null)
                return;

            string konum = cmbKonum.SelectedItem.ToString();

            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Vlan/Konum/" +
                    Uri.EscapeDataString(konum));

                vlanListesi =
                    JsonConvert.DeserializeObject<List<VlanModel>>(json);

                lstVlanlar.DataSource = null;
                lstVlanlar.DataSource = vlanListesi;

                DetaylariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "VLAN verileri alınamadı: " + ex.Message,
                    "Bağlantı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task AramaYap()
        {
            if (cmbKonum.SelectedItem == null)
                return;

            string kelime = txtAra.Text.Trim();

            if (string.IsNullOrEmpty(kelime))
            {
                await VlanlariGetir();
                return;
            }

            string konum = cmbKonum.SelectedItem.ToString();

            try
            {
                HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Vlan/Ara/" +
                    Uri.EscapeDataString(konum) + "/" +
                    Uri.EscapeDataString(kelime));

                vlanListesi =
                    JsonConvert.DeserializeObject<List<VlanModel>>(json);

                lstVlanlar.DataSource = null;
                lstVlanlar.DataSource = vlanListesi;

                DetaylariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Arama sırasında hata oluştu: " + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lstVlanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVlanlar.SelectedItem == null)
                return;

            seciliVlan = lstVlanlar.SelectedItem as VlanModel;

            if (seciliVlan != null)
                DetayGoster(seciliVlan);
        }

        private void DetayGoster(VlanModel vlan)
        {
            lblVlanNo.Text = "" + vlan.VlanNo;
            lblVlanAdi.Text = "" + vlan.VlanAdi;
            lblSubnet.Text = "" + BosDeger(vlan.Subnet);
            lblGateway.Text = "" + BosDeger(vlan.Gateway);
            lblKonum.Text = "" + BosDeger(vlan.Konum);
            lblAciklama.Text = "" + BosDeger(vlan.Aciklama);
            lblCihazSayisi.Text = "" + vlan.CihazSayisi;

            try
            {
                if (!string.IsNullOrWhiteSpace(vlan.Renk))
                    pnlRenk.BackColor = ColorTranslator.FromHtml(vlan.Renk);
                else
                    pnlRenk.BackColor = Color.Gray;
            }
            catch
            {
                pnlRenk.BackColor = Color.Gray;
            }
        }

        private void DetaylariTemizle()
        {
            seciliVlan = null;

            lblVlanNo.Text = "";
            lblVlanAdi.Text = "";
            lblSubnet.Text = "";
            lblGateway.Text = "";
            lblKonum.Text = "";
            lblAciklama.Text = "";
            lblCihazSayisi.Text = "";

            pnlRenk.BackColor = Color.Gray;
        }

        private string BosDeger(string deger)
        {
            if (string.IsNullOrWhiteSpace(deger))
                return "-";

            return deger;
        }

        private async void cmbKonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            await VlanlariGetir();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await AramaYap();
        }

        private async void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            await VlanlariGetir();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            VlanEkleForm form = new VlanEkleForm();
            form.ShowDialog();

            await VlanlariGetir();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliVlan == null)
            {
                MessageBox.Show("Lütfen güncellenecek VLAN seçiniz.");
                return;
            }

            VlanGuncelleForm form = new VlanGuncelleForm(seciliVlan);
            form.ShowDialog();

            await VlanlariGetir();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliVlan == null)
            {
                MessageBox.Show("Lütfen silinecek VLAN seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "VLAN " + seciliVlan.VlanNo + " - " + seciliVlan.VlanAdi + " silinsin mi?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cevap != DialogResult.Yes)
                return;

            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.DeleteAsync(
                    "https://localhost:7181/api/Vlan/Sil/" + seciliVlan.Id);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("VLAN silindi.");
                    await VlanlariGetir();
                }
                else
                {
                    string hata = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("VLAN silinemedi: " + hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Silme sırasında hata oluştu: " + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnlIstatistikStili()
        {
            pnlIstatistik.BackColor = Color.Transparent;
            pnlIstatistik.BorderStyle = BorderStyle.None;

            pnlIstatistik.Paint += delegate (object s, PaintEventArgs ev)
            {
                ev.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(1, 1, pnlIstatistik.Width - 2, pnlIstatistik.Height - 2);
                int radius = 12;

                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                using (System.Drawing.Drawing2D.LinearGradientBrush bg =
                    new System.Drawing.Drawing2D.LinearGradientBrush(
                        rect,
                        Color.White,
                        Color.FromArgb(245, 247, 252),
                        System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                {
                    ev.Graphics.FillPath(bg, path);
                }

                using (Pen pen = new Pen(Color.FromArgb(220, 225, 235), 1.5f))
                {
                    ev.Graphics.DrawPath(pen, path);
                }

                path.Dispose();
            };
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}