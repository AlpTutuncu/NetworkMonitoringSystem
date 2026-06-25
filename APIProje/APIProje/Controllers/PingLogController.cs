using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingLogController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            try
            {
                List<PingLogModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT TOP 200 Id, CihazId, CihazAdi, IPAdresi, Durum, KontrolTarihi
                      FROM PingLog
                      ORDER BY KontrolTarihi DESC",
                    baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new PingLogModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CihazId = Convert.ToInt32(reader["CihazId"]),
                        CihazAdi = reader["CihazAdi"].ToString(),
                        IPAdresi = reader["IPAdresi"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        KontrolTarihi = Convert.ToDateTime(reader["KontrolTarihi"])
                    });
                }

                return Ok(liste);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}