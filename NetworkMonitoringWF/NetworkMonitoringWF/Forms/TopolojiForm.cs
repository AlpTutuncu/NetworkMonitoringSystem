using NetworkMonitoringWF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class TopolojiForm : Form
    {
        private TopolojiResponseModel topoloji;
        private ToolTip nodeToolTip = new ToolTip();
        private int sonTooltipNodeId = -1;
        private TopolojiNodeModel seciliNode = null;
        private bool surukleniyor = false;
        private TopolojiNodeModel sagTiklananNode = null;
        private TopolojiNodeModel baglantiBaslatilanNode = null;
        private string kullaniciRol;

        public TopolojiForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            kullaniciRol = "Admin";

            this.StartPosition = FormStartPosition.CenterScreen;

            panelTopoloji.MouseMove += panelTopoloji_MouseMove;
            panelTopoloji.MouseDown += panelTopoloji_MouseDown;
            panelTopoloji.MouseMove += panelTopoloji_MouseMove_Drag;
            panelTopoloji.MouseUp += panelTopoloji_MouseUp;
            panelTopoloji.MouseClick += panelTopoloji_MouseClick;
        }

        public TopolojiForm(string rol)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            kullaniciRol = rol;

            this.StartPosition = FormStartPosition.CenterScreen;

            panelTopoloji.MouseMove += panelTopoloji_MouseMove;
            panelTopoloji.MouseDown += panelTopoloji_MouseDown;
            panelTopoloji.MouseMove += panelTopoloji_MouseMove_Drag;
            panelTopoloji.MouseUp += panelTopoloji_MouseUp;
            panelTopoloji.MouseClick += panelTopoloji_MouseClick;
        }

        private void panelTopoloji_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            if (topoloji == null)
                return;

            foreach (var node in topoloji.Nodes)
            {
                Rectangle rect = new Rectangle(
                    (int)node.PosX - 45,
                    (int)node.PosY - 25,
                    90,
                    50);

                if (rect.Contains(e.Location))
                {
                    sagTiklananNode = node;
                    contextMenuStrip1.Show(panelTopoloji, e.Location);
                    break;
                }
            }
        }


        private void panelTopoloji_MouseDown(object sender, MouseEventArgs e)
        {
            if (topoloji == null)
                return;

            // Sürükleme sadece Admin + Sol tık ile başlasın
            if (kullaniciRol != "Admin" || e.Button != MouseButtons.Left)
            {
                surukleniyor = false;
                seciliNode = null;
                return;
            }

            foreach (var node in topoloji.Nodes)
            {
                Rectangle rect = new Rectangle(
                    (int)node.PosX - 45,
                    (int)node.PosY - 25,
                    90,
                    50);

                if (rect.Contains(e.Location))
                {
                    seciliNode = node;
                    surukleniyor = true;
                    break;
                }
            }
        }

        private void panelTopoloji_MouseMove_Drag(object sender, MouseEventArgs e)
        {
            if (kullaniciRol != "Admin")
                return;

            if (!surukleniyor || seciliNode == null)
                return;

            seciliNode.PosX = e.X;
            seciliNode.PosY = e.Y;

            panelTopoloji.Invalidate();
        }

        private async void panelTopoloji_MouseUp(object sender, MouseEventArgs e)
        {
            if (seciliNode == null)
                return;

            surukleniyor = false;

            HttpClient client = new HttpClient();

            var data = new
            {
                PosX = seciliNode.PosX,
                PosY = seciliNode.PosY
            };

            string json =
                JsonConvert.SerializeObject(data);

            StringContent content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

            await client.PutAsync(
                $"https://localhost:7181/api/Topoloji/KonumGuncelle/{seciliNode.Id}",
                content);

            seciliNode = null;
        }

        private void panelTopoloji_MouseMove(object sender, MouseEventArgs e)
        {
            if (topoloji == null)
                return;

            foreach (var node in topoloji.Nodes)
            {
                Rectangle rect = new Rectangle(
                    (int)node.PosX - 45,
                    (int)node.PosY - 25,
                    90,
                    50);

                if (rect.Contains(e.Location))
                {
                    if (sonTooltipNodeId != node.Id)
                    {
                        sonTooltipNodeId = node.Id;

                        nodeToolTip.SetToolTip(
                        panelTopoloji,
                        "Cihaz: " + node.CihazAdi +
                        "\nIP: " + node.IPAdresi +
                        "\nTip: " + node.CihazTipi +
                        "\nKonum: " + node.Konum +
                        "\nDurum: " + node.Durum +
                        "\nVLAN: " + node.VlanBilgi);
                    }

                    return;
                }
            }

            sonTooltipNodeId = -1;
            nodeToolTip.SetToolTip(panelTopoloji, "");
        }

        private void RolYetkileriniUygula()
        {
            if (kullaniciRol == "Admin")
            {
                tsmPing.Visible = true;
                tsmDetay.Visible = true;
                tsmGuncelle.Visible = true;
                tsmSil.Visible = true;
                tsmBaglantiBaslat.Visible = true;
                tsmBaglantiSil.Visible = true;
            }
            else if (kullaniciRol == "Personel")
            {
                tsmPing.Visible = true;
                tsmDetay.Visible = true;

                tsmGuncelle.Visible = false;
                tsmSil.Visible = false;
                tsmBaglantiBaslat.Visible = false;
                tsmBaglantiSil.Visible = false;
            }
        }

        private async void TopolojiForm_Load(object sender, EventArgs e)
        {
            RolYetkileriniUygula();
            cmbKonum.SelectedIndex = 0;
            await TopolojiGetir();
           
        }

        private async void tsmPing_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            HttpClient client = new HttpClient();

            HttpResponseMessage response =
                await client.PostAsync(
                    $"https://localhost:7181/api/Ping/TekPing/{sagTiklananNode.Id}",
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
            }
            else
            {
                MessageBox.Show("Ping işlemi başarısız.");
            }

            await TopolojiGetir();
        }

        private async Task TopolojiGetir()
        {
            HttpClient client = new HttpClient();

            string konum = cmbKonum.Text;

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Topoloji/Konum/" + konum);

            topoloji = JsonConvert.DeserializeObject<TopolojiResponseModel>(json);

            panelTopoloji.Invalidate();
        }

        private void panelTopoloji_Paint(object sender, PaintEventArgs e)
        {
            if (topoloji == null)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Bağlantı çizgileri
            foreach (var link in topoloji.Links)
            {
                var from = topoloji.Nodes.FirstOrDefault(x => x.Id == link.FromCihazId);
                var to = topoloji.Nodes.FirstOrDefault(x => x.Id == link.ToCihazId);

                if (from == null || to == null)
                    continue;

                g.DrawLine(
                    new Pen(Color.Gray, 2),
                    (float)from.PosX,
                    (float)from.PosY,
                    (float)to.PosX,
                    (float)to.PosY);
            }

            // Node çizimleri
            foreach (var node in topoloji.Nodes)
            {
                Color renk = Color.Gray;

                if (node.Durum == "Aktif")
                    renk = Color.LightGreen;
                else if (node.Durum == "Pasif")
                    renk = Color.LightCoral;

                Rectangle rect = new Rectangle(
                    (int)node.PosX - 45,
                    (int)node.PosY - 25,
                    90,
                    50);

                using (SolidBrush brush = new SolidBrush(renk))
                {
                    NodeCiz(g, node, rect, brush);
                }

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString(
                    node.CihazAdi,
                    new Font("Segoe UI", 9, FontStyle.Bold),
                    Brushes.Black,
                    rect,
                    sf);
            }
        }

        private async void cmbKonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            await TopolojiGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tsmDetay_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            MessageBox.Show(
                "Cihaz Adı: " + sagTiklananNode.CihazAdi +
                "\nIP Adresi: " + sagTiklananNode.IPAdresi +
                "\nCihaz Tipi: " + sagTiklananNode.CihazTipi +
                "\nKonum: " + sagTiklananNode.Konum +
                "\nDurum: " + sagTiklananNode.Durum +
                "\nVLAN: " + sagTiklananNode.VlanBilgi,
                "Cihaz Detayı");
        }

        private async void tsmGuncelle_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            CihazGuncelleForm form = new CihazGuncelleForm(
                sagTiklananNode.Id,
                sagTiklananNode.CihazAdi,
                sagTiklananNode.IPAdresi,
                sagTiklananNode.CihazTipi,
                sagTiklananNode.Konum,
                sagTiklananNode.VlanId);

            form.ShowDialog();

            await TopolojiGetir();
        }

        private async void tsmSil_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            DialogResult cevap = MessageBox.Show(
                sagTiklananNode.CihazAdi + " cihazını silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cevap != DialogResult.Yes)
                return;

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.DeleteAsync(
                "https://localhost:7181/api/Cihaz/CihazSil/" + sagTiklananNode.Id);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cihaz silindi.");
                await TopolojiGetir();
            }
            else
            {
                MessageBox.Show("Cihaz silinemedi.");
            }
        }

        private async void tsmBaglantiBaslat_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            if (baglantiBaslatilanNode == null)
            {
                baglantiBaslatilanNode = sagTiklananNode;

                MessageBox.Show(
                    baglantiBaslatilanNode.CihazAdi + " cihazı seçildi.\nŞimdi bağlanacak ikinci cihaza sağ tıklayıp tekrar Bağlantı Başlat'a bas.",
                    "Bağlantı Başlatıldı");

                return;
            }

            if (baglantiBaslatilanNode.Id == sagTiklananNode.Id)
            {
                MessageBox.Show("Bir cihaz kendisine bağlanamaz.");
                baglantiBaslatilanNode = null;
                return;
            }

            HttpClient client = new HttpClient();

            var data = new
            {
                FromCihazId = baglantiBaslatilanNode.Id,
                ToCihazId = sagTiklananNode.Id
            };

            string json = JsonConvert.SerializeObject(data);

            StringContent content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.PostAsync(
                "https://localhost:7181/api/Topoloji/BaglantiEkle",
                content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Bağlantı eklendi.");
                await TopolojiGetir();
            }
            else
            {
                string hata = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Bağlantı eklenemedi: " + hata);
            }

            baglantiBaslatilanNode = null;
        }

        private async void tsmBaglantiSil_Click(object sender, EventArgs e)
        {
            if (sagTiklananNode == null)
                return;

            if (baglantiBaslatilanNode == null)
            {
                baglantiBaslatilanNode = sagTiklananNode;

                MessageBox.Show(
                    baglantiBaslatilanNode.CihazAdi + " cihazı seçildi.\nŞimdi bağlantısı silinecek ikinci cihaza sağ tıklayıp Bağlantıyı Sil'e bas.",
                    "Bağlantı Silme Başlatıldı");

                return;
            }

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.DeleteAsync(
                "https://localhost:7181/api/Topoloji/BaglantiSil/" +
                baglantiBaslatilanNode.Id + "/" +
                sagTiklananNode.Id);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Bağlantı silindi.");
                await TopolojiGetir();
            }
            else
            {
                MessageBox.Show("Bağlantı silinemedi.");
            }

            baglantiBaslatilanNode = null;
        }

        private void NodeCiz(Graphics g, TopolojiNodeModel node, Rectangle rect, Brush brush)
        {
            string tip = node.CihazTipi.ToLower();

            if (tip.Contains("router"))
            {
                Point[] altigen =
                {
            new Point(rect.Left + rect.Width / 4, rect.Top),
            new Point(rect.Right - rect.Width / 4, rect.Top),
            new Point(rect.Right, rect.Top + rect.Height / 2),
            new Point(rect.Right - rect.Width / 4, rect.Bottom),
            new Point(rect.Left + rect.Width / 4, rect.Bottom),
            new Point(rect.Left, rect.Top + rect.Height / 2)
        };

                g.FillPolygon(brush, altigen);
                g.DrawPolygon(Pens.Black, altigen);
            }
            else if (tip.Contains("switch"))
            {
                g.FillRectangle(brush, rect);
                g.DrawRectangle(Pens.Black, rect);
            }
            else if (tip.Contains("dns") || tip.Contains("server"))
            {
                Rectangle serverRect = new Rectangle(
                    rect.Left - 10,
                    rect.Top + 5,
                    rect.Width + 20,
                    rect.Height - 10);

                g.FillRectangle(brush, serverRect);
                g.DrawRectangle(Pens.Black, serverRect);
            }
            else if (tip.Contains("access") || tip.Contains("ap"))
            {
                g.FillEllipse(brush, rect);
                g.DrawEllipse(Pens.Black, rect);
            }
            else
            {
                g.FillEllipse(brush, rect);
                g.DrawEllipse(Pens.Black, rect);
            }
        }
    }
}