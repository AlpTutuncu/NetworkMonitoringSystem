using APIProje.Helpers;
using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly PingServiceState _state;

        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DashboardController(PingServiceState state)
        {
            _state = state;
        }

        [HttpGet("Ozet")]
        public IActionResult Ozet()
        {
            try
            {
                DashboardModel model = new DashboardModel();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                model.ToplamCihaz = Convert.ToInt32(
                    new SqlCommand("SELECT COUNT(*) FROM Cihazlar", baglanti)
                    .ExecuteScalar());

                model.AktifCihaz = Convert.ToInt32(
                    new SqlCommand("SELECT COUNT(*) FROM Cihazlar WHERE Durum='Aktif'", baglanti)
                    .ExecuteScalar());

                model.PasifCihaz = Convert.ToInt32(
                    new SqlCommand("SELECT COUNT(*) FROM Cihazlar WHERE Durum='Pasif'", baglanti)
                    .ExecuteScalar());

                model.BilinmeyenCihaz = Convert.ToInt32(
                    new SqlCommand("SELECT COUNT(*) FROM Cihazlar WHERE Durum='Bilinmiyor'", baglanti)
                    .ExecuteScalar());

                object sonKontrol = new SqlCommand(
                    "SELECT MAX(SonKontrolTarihi) FROM Cihazlar",
                    baglanti).ExecuteScalar();

                model.SonKontrolZamani =
                    sonKontrol == DBNull.Value ? "-" :
                    Convert.ToDateTime(sonKontrol).ToString("dd.MM.yyyy HH:mm:ss");

                SqlCommand sonIslemKomut = new SqlCommand(
                @"SELECT TOP 1 Kullanici, Islem FROM IslemLog ORDER BY Tarih DESC", baglanti);

                SqlDataReader sonIslemReader = sonIslemKomut.ExecuteReader();

                if (sonIslemReader.Read())
                {
                    string kullanici = sonIslemReader["Kullanici"].ToString();
                    string islem = sonIslemReader["Islem"].ToString();

                    model.SonIslem = kullanici + " - " + islem;
                }
                else
                {
                    model.SonIslem = "-";
                }

                sonIslemReader.Close();

                object sonAlarm = new SqlCommand(
                @"SELECT TOP 1 Mesaj
                FROM AlarmBildirim
                ORDER BY Tarih DESC",
                baglanti).ExecuteScalar();

                model.SonAlarm =
                    sonAlarm == null || sonAlarm == DBNull.Value
                    ? "Alarm kaydı bulunamadı."
                    : sonAlarm.ToString();

                model.CihazTipDagilimi = new List<CihazTipDagilimModel>();

                SqlCommand tipKomut = new SqlCommand(
                    @"SELECT CihazTipi, COUNT(*) AS Adet
                    FROM Cihazlar
                    GROUP BY CihazTipi
                    ORDER BY Adet DESC",
                    baglanti);

                SqlDataReader tipReader = tipKomut.ExecuteReader();

                while (tipReader.Read())
                {
                    model.CihazTipDagilimi.Add(new CihazTipDagilimModel
                    {
                        CihazTipi = tipReader["CihazTipi"].ToString(),
                        Adet = Convert.ToInt32(tipReader["Adet"])
                    });
                }

                tipReader.Close();

                model.PingServisAktifMi = _state.IsActive;

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}