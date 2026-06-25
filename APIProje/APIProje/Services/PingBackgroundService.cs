using APIProje.Helpers;
using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;

namespace APIProje
{
    public class PingBackgroundService : BackgroundService
    {
        private readonly PingServiceState _state;

        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public PingBackgroundService(PingServiceState state)
        {
            _state = state;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (!_state.IsActive)
                {
                    await Task.Delay(3000, stoppingToken);
                    continue;
                }

                try
                {
                    List<(int Id, string CihazAdi, string IPAdresi, string EskiDurum)> cihazlar = new List<(int, string, string, string)>();

                    using (SqlConnection baglanti = new SqlConnection(connStr))
                    {
                        await baglanti.OpenAsync();

                        SqlCommand listeKomut = new SqlCommand(
                        "SELECT Id, CihazAdi, IPAdresi, Durum FROM Cihazlar", baglanti);

                        SqlDataReader reader = await listeKomut.ExecuteReaderAsync();

                        while (reader.Read())
                        {
                            cihazlar.Add((
                                Convert.ToInt32(reader["Id"]),
                                reader["CihazAdi"].ToString(),
                                reader["IPAdresi"].ToString(),
                                reader["Durum"].ToString()
                            ));
                        }

                        reader.Close();

                        foreach (var cihaz in cihazlar)
                        {
                            string durum = "Pasif";

                            try
                            {
                                Ping ping = new Ping();
                                PingReply reply = await ping.SendPingAsync(cihaz.IPAdresi, 1000);

                                if (reply.Status == IPStatus.Success)
                                    durum = "Aktif";
                            }
                            catch
                            {
                                durum = "Pasif";
                            }

                            // Durum değişti mi kontrol et
                            // Sadece Aktif -> Pasif veya Pasif -> Aktif geçişlerinde alarm üretir.
                            if ((cihaz.EskiDurum == "Aktif" && durum == "Pasif") ||
                                (cihaz.EskiDurum == "Pasif" && durum == "Aktif"))
                            {
                                string mesaj = cihaz.CihazAdi + " cihazı " +
                                               cihaz.EskiDurum + " durumundan " +
                                               durum + " durumuna geçti.";

                                SqlCommand alarmKomut = new SqlCommand(
                                    @"INSERT INTO AlarmBildirim
                                    (CihazId, CihazAdi, IPAdresi, EskiDurum, YeniDurum, Mesaj) VALUES
                                    (@cihazId, @cihazAdi, @ipAdresi, @eskiDurum, @yeniDurum, @mesaj)", baglanti);

                                alarmKomut.Parameters.AddWithValue("@cihazId", cihaz.Id);
                                alarmKomut.Parameters.AddWithValue("@cihazAdi", cihaz.CihazAdi);
                                alarmKomut.Parameters.AddWithValue("@ipAdresi", cihaz.IPAdresi);
                                alarmKomut.Parameters.AddWithValue("@eskiDurum", cihaz.EskiDurum);
                                alarmKomut.Parameters.AddWithValue("@yeniDurum", durum);
                                alarmKomut.Parameters.AddWithValue("@mesaj", mesaj);

                                await alarmKomut.ExecuteNonQueryAsync();

                                LogHelper log = new LogHelper();
                                log.LogEkle("Sistem", mesaj);
                            }

                            // Cihazın güncel durumunu Cihazlar tablosuna yaz
                            SqlCommand guncelleKomut = new SqlCommand(
                                @"UPDATE Cihazlar
          SET Durum=@durum,
              SonKontrolTarihi=GETDATE()
          WHERE Id=@id",
                                baglanti);

                            guncelleKomut.Parameters.AddWithValue("@durum", durum);
                            guncelleKomut.Parameters.AddWithValue("@id", cihaz.Id);

                            await guncelleKomut.ExecuteNonQueryAsync();

                            // Her ping sonucunu PingLog tablosuna yaz
                            SqlCommand logKomut = new SqlCommand(
                                @"INSERT INTO PingLog
          (CihazId, CihazAdi, IPAdresi, Durum)
          VALUES
          (@cihazId, @cihazAdi, @ipAdresi, @durum)",
                                baglanti);

                            logKomut.Parameters.AddWithValue("@cihazId", cihaz.Id);
                            logKomut.Parameters.AddWithValue("@cihazAdi", cihaz.CihazAdi);
                            logKomut.Parameters.AddWithValue("@ipAdresi", cihaz.IPAdresi);
                            logKomut.Parameters.AddWithValue("@durum", durum);

                            await logKomut.ExecuteNonQueryAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ping servis hatası: " + ex.Message);
                }

                await Task.Delay(30000, stoppingToken);
            }
        }
    }
}