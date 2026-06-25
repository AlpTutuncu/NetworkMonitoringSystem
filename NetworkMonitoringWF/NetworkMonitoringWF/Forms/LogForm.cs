using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkMonitoringWF.Models;

namespace NetworkMonitoringWF
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void LogForm_Load(object sender, EventArgs e)
        {
            await LogListele();
        }

        private async Task LogListele()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(
                "https://localhost:7181/api/Log/LogListele");

            List<IslemLogModel> loglar =
                JsonConvert.DeserializeObject<List<IslemLogModel>>(json);

            dataGridView1.DataSource = loglar;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}