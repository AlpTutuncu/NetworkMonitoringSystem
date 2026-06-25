using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using APIProje.Models;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest data)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT Id, KullaniciAdi, Rol
                      FROM Kullanicilar
                      WHERE KullaniciAdi=@kadi AND Sifre=@sifre",
                    baglanti);

                komut.Parameters.AddWithValue("@kadi", data.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", data.Sifre);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    LoginResponse user = new LoginResponse
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };

                    LogHelper log = new LogHelper();
                    log.LogEkle(user.KullaniciAdi, "Sisteme giriş yaptı.");

                    return Ok(user);
                }

                return Unauthorized("Kullanıcı adı veya şifre hatalı.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Logout")]
        public IActionResult Logout([FromBody] LogoutRequest data)
        {
            try
            {
                LogHelper log = new LogHelper();
                log.LogEkle(data.KullaniciAdi, "Sistemden çıkış yaptı.");

                return Ok("Çıkış loglandı.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}