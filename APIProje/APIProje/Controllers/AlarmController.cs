using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmController : ControllerBase
    {
        private readonly string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("SonOkunmamis")]
        public IActionResult SonOkunmamis()
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT TOP 1 Id, CihazId, CihazAdi, IPAdresi,
                             EskiDurum, YeniDurum, Mesaj, Tarih, OkunduMu
                      FROM AlarmBildirim
                      WHERE OkunduMu = 0
                      ORDER BY Tarih DESC",
                    baglanti);

                using SqlDataReader reader = komut.ExecuteReader();

                if (!reader.Read())
                    return Ok(null);

                AlarmBildirimModel alarm = new AlarmBildirimModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CihazId = Convert.ToInt32(reader["CihazId"]),
                    CihazAdi = reader["CihazAdi"].ToString(),
                    IPAdresi = reader["IPAdresi"].ToString(),
                    EskiDurum = reader["EskiDurum"].ToString(),
                    YeniDurum = reader["YeniDurum"].ToString(),
                    Mesaj = reader["Mesaj"].ToString(),
                    Tarih = Convert.ToDateTime(reader["Tarih"]),
                    OkunduMu = Convert.ToBoolean(reader["OkunduMu"])
                };

                return Ok(alarm);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Okundu/{id}")]
        public IActionResult Okundu(int id)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"UPDATE AlarmBildirim
                      SET OkunduMu = 1
                      WHERE Id = @id",
                    baglanti);

                komut.Parameters.AddWithValue("@id", id);

                int etkilenenSatir = komut.ExecuteNonQuery();

                if (etkilenenSatir == 0)
                    return NotFound("Alarm kaydı bulunamadı.");

                return Ok("Alarm okundu olarak işaretlendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}