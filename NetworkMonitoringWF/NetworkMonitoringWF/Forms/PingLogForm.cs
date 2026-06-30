using Newtonsoft.Json;
using NetworkMonitoringWF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoringWF.Forms
{
    public partial class PingLogForm : Form
    {
        public PingLogForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void PingLogForm_Load(object sender, EventArgs e)
        {
            await PingLogListele();
        }

        private async Task PingLogListele()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/PingLog/Listele");

            List<PingLogModel> loglar =
                JsonConvert.DeserializeObject<List<PingLogModel>>(json);

            dgvPingLog.DataSource = loglar;
            dgvPingLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPingLog.AllowUserToAddRows = false;
            dgvPingLog.ReadOnly = true;

            GridGenelAyarlar();
            KolonBasliklariniAyarla();
            KolonSirasiAyarla();
        }

        private void GridGenelAyarlar()
        {
            dgvPingLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPingLog.AllowUserToAddRows = false;
            dgvPingLog.ReadOnly = true;
            dgvPingLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPingLog.MultiSelect = false;

            dgvPingLog.EnableHeadersVisualStyles = false;

            dgvPingLog.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvPingLog.ColumnHeadersHeight = 45;

            dgvPingLog.RowTemplate.Height = 38;

            foreach (DataGridViewRow row in dgvPingLog.Rows)
            {
                row.Height = 38;
            }
        }

        private void KolonBasliklariniAyarla()
        {
            if (dgvPingLog.Columns.Contains("Id"))
                dgvPingLog.Columns["Id"].HeaderText = "ID";

            if (dgvPingLog.Columns.Contains("CihazId"))
                dgvPingLog.Columns["CihazId"].Visible = false;

            if (dgvPingLog.Columns.Contains("CihazAdi"))
                dgvPingLog.Columns["CihazAdi"].HeaderText = "Cihaz Adı";

            if (dgvPingLog.Columns.Contains("IPAdresi"))
                dgvPingLog.Columns["IPAdresi"].HeaderText = "IP Adresi";

            if (dgvPingLog.Columns.Contains("Durum"))
                dgvPingLog.Columns["Durum"].HeaderText = "Durum";

            if (dgvPingLog.Columns.Contains("KontrolTarihi"))
                dgvPingLog.Columns["KontrolTarihi"].HeaderText = "Kontrol Tarihi";
        }

        private void KolonSirasiAyarla()
        {
            int index = 0;

            if (dgvPingLog.Columns.Contains("Id"))
                dgvPingLog.Columns["Id"].DisplayIndex = index++;

            if (dgvPingLog.Columns.Contains("CihazAdi"))
                dgvPingLog.Columns["CihazAdi"].DisplayIndex = index++;

            if (dgvPingLog.Columns.Contains("IPAdresi"))
                dgvPingLog.Columns["IPAdresi"].DisplayIndex = index++;

            if (dgvPingLog.Columns.Contains("Durum"))
                dgvPingLog.Columns["Durum"].DisplayIndex = index++;

            if (dgvPingLog.Columns.Contains("KontrolTarihi"))
                dgvPingLog.Columns["KontrolTarihi"].DisplayIndex = index++;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}