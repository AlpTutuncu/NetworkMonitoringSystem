using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            try
            {
                List<KullaniciModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT Id, KullaniciAdi, Sifre, Rol
                      FROM Kullanicilar
                      ORDER BY Id DESC",
                    baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new KullaniciModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Rol = reader["Rol"].ToString()
                    });
                }

                return Ok(liste);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Ekle")]
        public IActionResult Ekle([FromBody] KullaniciModel data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data.KullaniciAdi))
                    return BadRequest("Kullanıcı adı boş olamaz.");

                if (string.IsNullOrWhiteSpace(data.Sifre))
                    return BadRequest("Şifre boş olamaz.");

                if (data.Rol != "Admin" && data.Rol != "Personel")
                    return BadRequest("Rol sadece Admin veya Personel olabilir.");

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand(
                    @"SELECT COUNT(*) 
                      FROM Kullanicilar 
                      WHERE KullaniciAdi = @kullaniciAdi",
                    baglanti);

                kontrolKomut.Parameters.AddWithValue("@kullaniciAdi", data.KullaniciAdi);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                    return BadRequest("Bu kullanıcı adı zaten mevcut.");

                SqlCommand komut = new SqlCommand(
                    @"INSERT INTO Kullanicilar
                      (KullaniciAdi, Sifre, Rol)
                      VALUES
                      (@kullaniciAdi, @sifre, @rol)",
                    baglanti);

                komut.Parameters.AddWithValue("@kullaniciAdi", data.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", data.Sifre);
                komut.Parameters.AddWithValue("@rol", data.Rol);

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", data.KullaniciAdi + " kullanıcısı oluşturuldu.");

                return Ok("Kullanıcı eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Guncelle")]
        public IActionResult Guncelle([FromBody] KullaniciModel data)
        {
            try
            {
                if (data.Id <= 0)
                    return BadRequest("Geçersiz kullanıcı Id.");

                if (string.IsNullOrWhiteSpace(data.KullaniciAdi))
                    return BadRequest("Kullanıcı adı boş olamaz.");

                if (string.IsNullOrWhiteSpace(data.Sifre))
                    return BadRequest("Şifre boş olamaz.");

                if (data.Rol != "Admin" && data.Rol != "Personel")
                    return BadRequest("Rol sadece Admin veya Personel olabilir.");

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand(
                    @"SELECT COUNT(*) 
                      FROM Kullanicilar 
                      WHERE KullaniciAdi = @kullaniciAdi
                        AND Id <> @id",
                    baglanti);

                kontrolKomut.Parameters.AddWithValue("@kullaniciAdi", data.KullaniciAdi);
                kontrolKomut.Parameters.AddWithValue("@id", data.Id);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                    return BadRequest("Bu kullanıcı adı başka bir kullanıcıda mevcut.");

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Kullanicilar
                      SET KullaniciAdi = @kullaniciAdi,
                          Sifre = @sifre,
                          Rol = @rol
                      WHERE Id = @id",
                    baglanti);

                komut.Parameters.AddWithValue("@id", data.Id);
                komut.Parameters.AddWithValue("@kullaniciAdi", data.KullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", data.Sifre);
                komut.Parameters.AddWithValue("@rol", data.Rol);

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", data.KullaniciAdi + " kullanıcısı güncellendi.");

                return Ok("Kullanıcı güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Sil/{id}")]
        public IActionResult Sil(int id)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand bilgiKomut = new SqlCommand(
                    "SELECT KullaniciAdi FROM Kullanicilar WHERE Id = @id",
                    baglanti);

                bilgiKomut.Parameters.AddWithValue("@id", id);

                object kullaniciObj = bilgiKomut.ExecuteScalar();

                if (kullaniciObj == null)
                    return NotFound("Kullanıcı bulunamadı.");

                string kullaniciAdi = kullaniciObj.ToString();

                SqlCommand silKomut = new SqlCommand(
                    "DELETE FROM Kullanicilar WHERE Id = @id",
                    baglanti);

                silKomut.Parameters.AddWithValue("@id", id);
                silKomut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", kullaniciAdi + " kullanıcısı silindi.");

                return Ok("Kullanıcı silindi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}