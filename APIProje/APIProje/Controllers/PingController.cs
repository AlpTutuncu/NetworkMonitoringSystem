using APIProje.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly PingServiceState _state;

        public PingController(PingServiceState state)
        {
            _state = state;
        }

        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpPost("TekPing/{id}")]
        public IActionResult TekPing(int id)
        {
            try
            {
                string cihazAdi = "";
                string ipAdresi = "";

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand cihazKomut = new SqlCommand(
                    "SELECT CihazAdi, IPAdresi FROM Cihazlar WHERE Id=@id",
                    baglanti);

                cihazKomut.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cihazKomut.ExecuteReader();

                if (reader.Read())
                {
                    cihazAdi = reader["CihazAdi"].ToString();
                    ipAdresi = reader["IPAdresi"].ToString();
                }
                else
                {
                    return NotFound("Cihaz bulunamadı.");
                }

                reader.Close();

                Ping ping = new Ping();
                PingReply reply = ping.Send(ipAdresi, 1000);

                string durum = reply.Status == IPStatus.Success ? "Aktif" : "Pasif";
                long gecikme = reply.Status == IPStatus.Success ? reply.RoundtripTime : -1;

                SqlCommand guncelleKomut = new SqlCommand(
                    @"UPDATE Cihazlar 
                      SET Durum=@durum, SonKontrolTarihi=GETDATE()
                      WHERE Id=@id",
                    baglanti);

                guncelleKomut.Parameters.AddWithValue("@durum", durum);
                guncelleKomut.Parameters.AddWithValue("@id", id);
                guncelleKomut.ExecuteNonQuery();

                SqlCommand logKomut = new SqlCommand(
                    @"INSERT INTO PingLog 
                      (CihazId, CihazAdi, IPAdresi, Durum)
                      VALUES 
                      (@cihazId, @cihazAdi, @ipAdresi, @durum)",
                    baglanti);

                logKomut.Parameters.AddWithValue("@cihazId", id);
                logKomut.Parameters.AddWithValue("@cihazAdi", cihazAdi);
                logKomut.Parameters.AddWithValue("@ipAdresi", ipAdresi);
                logKomut.Parameters.AddWithValue("@durum", durum);
                logKomut.ExecuteNonQuery();

                return Ok(new
                {
                    cihazAdi,
                    ipAdresi,
                    durum,
                    gecikme
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("Baslat")]
        public IActionResult Baslat()
        {
            _state.IsActive = true;
            LogHelper log = new LogHelper();
            log.LogEkle("Sistem", "Ping servisi başlatıldı.");
            return Ok("Ping servisi başlatıldı.");
        }

        [HttpPost("Durdur")]
        public IActionResult Durdur()
        {
            _state.IsActive = false;
            LogHelper log = new LogHelper();
            log.LogEkle("Sistem", "Ping servisi durduruldu.");
            return Ok("Ping servisi durduruldu.");
        }

        [HttpGet("Durum")]
        public IActionResult Durum()
        {
            return Ok(new
            {
                aktifMi = _state.IsActive
            });
        }
    }
}