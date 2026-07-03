using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class VlanYonetimForm : Form
    {
        private readonly HttpClient client = new HttpClient();
        private List<VlanModel> vlanListesi = new List<VlanModel>();
        private VlanModel seciliVlan = null;
        private string kullaniciRol;

        public VlanYonetimForm(string rol)
        {
            InitializeComponent();
            FormAyarla();
            kullaniciRol = rol;
        }

        public VlanYonetimForm()
        {
            InitializeComponent();
            FormAyarla();
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

        private void FormAyarla()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "VLAN Yönetimi";

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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

            PanelKoseYuvarlat(panel1, 20);
            PanelKoseYuvarlat(pnlRenk, 12);
        }

        private async Task VlanlariGetir()
        {
            if (cmbKonum.SelectedItem == null)
                return;

            string konum = cmbKonum.SelectedItem.ToString();

            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Vlan/Konum/" +
                    Uri.EscapeDataString(konum));

                vlanListesi =
                    JsonConvert.DeserializeObject<List<VlanModel>>(json);

                GridiDoldur(vlanListesi);
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
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Vlan/Ara/" +
                    Uri.EscapeDataString(konum) + "/" +
                    Uri.EscapeDataString(kelime));

                vlanListesi =
                    JsonConvert.DeserializeObject<List<VlanModel>>(json);

                GridiDoldur(vlanListesi);
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

        private void GridiDoldur(List<VlanModel> vlanlar)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vlanlar;

            GridGenelAyarlar();
            KolonBasliklariniAyarla();
            KolonSirasiAyarla();

            if (vlanlar != null && vlanlar.Count > 0 && dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[0].Selected = true;

                foreach (DataGridViewCell cell in dataGridView1.Rows[0].Cells)
                {
                    if (cell.Visible)
                    {
                        dataGridView1.CurrentCell = cell;
                        break;
                    }
                }

                seciliVlan = vlanlar[0];
                DetayGoster(seciliVlan);
            }
            else
            {
                DetaylariTemizle();
            }
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
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns.Contains("Renk"))
                dataGridView1.Columns["Renk"].Visible = false;

            if (dataGridView1.Columns.Contains("VlanNo"))
                dataGridView1.Columns["VlanNo"].HeaderText = "VLAN No";

            if (dataGridView1.Columns.Contains("VlanAdi"))
                dataGridView1.Columns["VlanAdi"].HeaderText = "VLAN Adı";

            if (dataGridView1.Columns.Contains("Subnet"))
                dataGridView1.Columns["Subnet"].HeaderText = "Subnet";

            if (dataGridView1.Columns.Contains("Gateway"))
                dataGridView1.Columns["Gateway"].HeaderText = "Gateway";

            if (dataGridView1.Columns.Contains("Konum"))
                dataGridView1.Columns["Konum"].Visible = false;

            if (dataGridView1.Columns.Contains("Aciklama"))
                dataGridView1.Columns["Aciklama"].Visible = false;

            if (dataGridView1.Columns.Contains("CihazSayisi"))
                dataGridView1.Columns["CihazSayisi"].HeaderText = "Cihaz Sayısı";
        }

        private void KolonSirasiAyarla()
        {
            int index = 0;

            if (dataGridView1.Columns.Contains("VlanNo"))
                dataGridView1.Columns["VlanNo"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("VlanAdi"))
                dataGridView1.Columns["VlanAdi"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Subnet"))
                dataGridView1.Columns["Subnet"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Gateway"))
                dataGridView1.Columns["Gateway"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("CihazSayisi"))
                dataGridView1.Columns["CihazSayisi"].DisplayIndex = index++;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.RowIndex >= vlanListesi.Count)
                return;

            seciliVlan = vlanListesi[e.RowIndex];

            if (seciliVlan != null)
                DetayGoster(seciliVlan);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int rowIndex = dataGridView1.CurrentRow.Index;

            if (rowIndex < 0 || rowIndex >= vlanListesi.Count)
                return;

            seciliVlan = vlanListesi[rowIndex];

            if (seciliVlan != null)
                DetayGoster(seciliVlan);
        }

        private void DetayGoster(VlanModel vlan)
        {
            lblVlanNo.Text = "" + vlan.VlanNo;
            lblVlanAdi.Text = "" + vlan.VlanAdi;
            lblSubnet.Text = "" + BosDeger(vlan.Subnet);
            lblGateway.Text = "" + BosDeger(vlan.Gateway);
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
    }
}