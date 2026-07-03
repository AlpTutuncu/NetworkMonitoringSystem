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
        private readonly HttpClient client = new HttpClient();

        public LogForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void LogForm_Load(object sender, EventArgs e)
        {
            await LogListele();
        }

        private async Task LogListele()
        {
            try
            {
                string json = await client.GetStringAsync(
                    "https://localhost:7181/api/Log/LogListele");

                List<IslemLogModel> loglar =
                    JsonConvert.DeserializeObject<List<IslemLogModel>>(json);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = loglar;

                GridGenelAyarlar();
                KolonBasliklariniAyarla();
                KolonSirasiAyarla();
                KolonGenislikleriniAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem kayıtları listelenemedi: " + ex.Message);
            }
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
                dataGridView1.Columns["Id"].HeaderText = "ID";

            if (dataGridView1.Columns.Contains("Kullanici"))
                dataGridView1.Columns["Kullanici"].HeaderText = "Kullanıcı";

            if (dataGridView1.Columns.Contains("Islem"))
                dataGridView1.Columns["Islem"].HeaderText = "İşlem";

            if (dataGridView1.Columns.Contains("Tarih"))
                dataGridView1.Columns["Tarih"].HeaderText = "Tarih";
        }

        private void KolonSirasiAyarla()
        {
            int index = 0;

            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Kullanici"))
                dataGridView1.Columns["Kullanici"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Islem"))
                dataGridView1.Columns["Islem"].DisplayIndex = index++;

            if (dataGridView1.Columns.Contains("Tarih"))
                dataGridView1.Columns["Tarih"].DisplayIndex = index++;
        }

        private void KolonGenislikleriniAyarla()
        {
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None;

                dataGridView1.Columns["Id"].Width = 70;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}