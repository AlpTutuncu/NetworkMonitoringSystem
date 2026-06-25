using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using APIProje.Models;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("LogListele")]
        public IActionResult LogListele()
        {
            try
            {
                List<IslemLogModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT TOP 200 Id, Kullanici, Islem, Tarih
                      FROM IslemLog
                      ORDER BY Tarih DESC",
                    baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new IslemLogModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Kullanici = reader["Kullanici"].ToString(),
                        Islem = reader["Islem"].ToString(),
                        Tarih = Convert.ToDateTime(reader["Tarih"])
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