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
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}