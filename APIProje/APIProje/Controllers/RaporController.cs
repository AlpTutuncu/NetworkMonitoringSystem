using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaporController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("Ozet")]
        public IActionResult Ozet()
        {
            try
            {
                RaporModel rapor = new RaporModel();
                rapor.RaporTarihi = DateTime.Now;
                rapor.SonAlarmlar = new List<string>();
                rapor.SonIslemler = new List<string>();
                rapor.SonPingler = new List<string>();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand cihazKomut = new SqlCommand(
                    @"SELECT 
                        COUNT(*) AS ToplamCihaz,
                        SUM(CASE WHEN Durum = 'Aktif' THEN 1 ELSE 0 END) AS AktifCihaz,
                        SUM(CASE WHEN Durum = 'Pasif' THEN 1 ELSE 0 END) AS PasifCihaz,
                        SUM(CASE WHEN Durum = 'Bilinmiyor' THEN 1 ELSE 0 END) AS BilinmeyenCihaz
                      FROM Cihazlar",
                    baglanti);

                SqlDataReader cihazReader = cihazKomut.ExecuteReader();

                if (cihazReader.Read())
                {
                    rapor.ToplamCihaz = Convert.ToInt32(cihazReader["ToplamCihaz"]);
                    rapor.AktifCihaz = Convert.ToInt32(cihazReader["AktifCihaz"]);
                    rapor.PasifCihaz = Convert.ToInt32(cihazReader["PasifCihaz"]);
                    rapor.BilinmeyenCihaz = Convert.ToInt32(cihazReader["BilinmeyenCihaz"]);
                }

                cihazReader.Close();

                SqlCommand vlanKomut = new SqlCommand(
                    "SELECT COUNT(*) FROM Vlanlar",
                    baglanti);

                rapor.ToplamVlan = Convert.ToInt32(vlanKomut.ExecuteScalar());

                SqlCommand alarmKomut = new SqlCommand(
                    @"SELECT TOP 5 Mesaj, Tarih
                      FROM AlarmBildirim
                      ORDER BY Tarih DESC",
                    baglanti);

                SqlDataReader alarmReader = alarmKomut.ExecuteReader();

                while (alarmReader.Read())
                {
                    string satir =
                        Convert.ToDateTime(alarmReader["Tarih"]).ToString("dd.MM.yyyy HH:mm") +
                        " - " +
                        alarmReader["Mesaj"].ToString();

                    rapor.SonAlarmlar.Add(satir);
                }

                alarmReader.Close();

                SqlCommand islemKomut = new SqlCommand(
                    @"SELECT TOP 5 Kullanici, Islem, Tarih
                      FROM IslemLog
                      ORDER BY Tarih DESC",
                    baglanti);

                SqlDataReader islemReader = islemKomut.ExecuteReader();

                while (islemReader.Read())
                {
                    string satir =
                        Convert.ToDateTime(islemReader["Tarih"]).ToString("dd.MM.yyyy HH:mm") +
                        " - " +
                        islemReader["Kullanici"].ToString() +
                        " - " +
                        islemReader["Islem"].ToString();

                    rapor.SonIslemler.Add(satir);
                }

                islemReader.Close();

                SqlCommand pingKomut = new SqlCommand(
                    @"SELECT TOP 5 CihazAdi, IPAdresi, Durum, KontrolTarihi
                      FROM PingLog
                      ORDER BY KontrolTarihi DESC",
                    baglanti);

                SqlDataReader pingReader = pingKomut.ExecuteReader();

                while (pingReader.Read())
                {
                    string satir =
                        Convert.ToDateTime(pingReader["KontrolTarihi"]).ToString("dd.MM.yyyy HH:mm") +
                        " - " +
                        pingReader["CihazAdi"].ToString() +
                        " (" + pingReader["IPAdresi"].ToString() + ")" +
                        " - " +
                        pingReader["Durum"].ToString();

                    rapor.SonPingler.Add(satir);
                }

                pingReader.Close();

                return Ok(rapor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}