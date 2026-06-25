using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using APIProje.Models;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CihazController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("CihazListele")]
        public IActionResult CihazListele()
        {
            try
            {
                List<Cihaz> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT c.Id, c.CihazAdi, c.IPAdresi, c.CihazTipi, c.Konum, c.Durum,
                     c.VlanId,
                     CASE 
                         WHEN v.Id IS NULL THEN '-'
                         ELSE CAST(v.VlanNo AS NVARCHAR) + ' - ' + v.VlanAdi
                     END AS VlanBilgi
              FROM Cihazlar c
              LEFT JOIN Vlanlar v ON c.VlanId = v.Id",
                    baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Cihaz
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CihazAdi = reader["CihazAdi"].ToString(),
                        IPAdresi = reader["IPAdresi"].ToString(),
                        CihazTipi = reader["CihazTipi"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Durum = reader["Durum"].ToString(),

                        VlanId = reader["VlanId"] == DBNull.Value
                            ? null
                            : Convert.ToInt32(reader["VlanId"]),

                        VlanBilgi = reader["VlanBilgi"].ToString()
                    });
                }

                return Ok(liste);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CihazEkle")]
        public IActionResult CihazEkle([FromBody] CihazEkleModel data)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"INSERT INTO Cihazlar
              (CihazAdi, IPAdresi, CihazTipi, Konum, Durum, VlanId)
              VALUES
              (@ad, @ip, @tip, @konum, 'Bilinmiyor', @vlanId)",
                    baglanti);

                komut.Parameters.AddWithValue("@ad", data.CihazAdi);
                komut.Parameters.AddWithValue("@ip", data.IPAdresi);
                komut.Parameters.AddWithValue("@tip", data.CihazTipi);
                komut.Parameters.AddWithValue("@konum", data.Konum);

                komut.Parameters.AddWithValue(
                    "@vlanId",
                    data.VlanId == null ? DBNull.Value : data.VlanId);

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", data.CihazAdi + " cihazı eklendi.");

                return Ok("Cihaz eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("CihazSil/{id}")]
        public IActionResult CihazSil(int id)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand cihazBulKomut = new SqlCommand(
                    "SELECT CihazAdi FROM Cihazlar WHERE Id=@id",
                    baglanti);

                cihazBulKomut.Parameters.AddWithValue("@id", id);

                object cihazAdiObj = cihazBulKomut.ExecuteScalar();

                if (cihazAdiObj == null)
                    return NotFound("Cihaz bulunamadı.");

                string cihazAdi = cihazAdiObj.ToString();

                SqlCommand silKomut = new SqlCommand(
                    "DELETE FROM Cihazlar WHERE Id=@id",
                    baglanti);

                silKomut.Parameters.AddWithValue("@id", id);
                silKomut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", cihazAdi + " cihazı silindi.");

                return Ok("Cihaz silindi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("CihazGuncelle")]
        public IActionResult CihazGuncelle([FromBody] CihazGuncelleModel data)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Cihazlar
              SET CihazAdi = @ad,
                  IPAdresi = @ip,
                  CihazTipi = @tip,
                  Konum = @konum,
                  VlanId = @vlanId
              WHERE Id = @id",
                    baglanti);

                komut.Parameters.AddWithValue("@id", data.Id);
                komut.Parameters.AddWithValue("@ad", data.CihazAdi);
                komut.Parameters.AddWithValue("@ip", data.IPAdresi);
                komut.Parameters.AddWithValue("@tip", data.CihazTipi);
                komut.Parameters.AddWithValue("@konum", data.Konum);

                komut.Parameters.AddWithValue(
                    "@vlanId",
                    data.VlanId == null ? DBNull.Value : data.VlanId);

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", data.CihazAdi + " cihazı güncellendi.");

                return Ok("Cihaz güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("CihazAra/{kelime}")]
        public IActionResult CihazAra(string kelime)
        {
            try
            {
                List<Cihaz> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT c.Id, c.CihazAdi, c.IPAdresi, c.CihazTipi, c.Konum, c.Durum,
                     c.VlanId,
                     CASE 
                         WHEN v.Id IS NULL THEN '-'
                         ELSE CAST(v.VlanNo AS NVARCHAR) + ' - ' + v.VlanAdi
                     END AS VlanBilgi
              FROM Cihazlar c
              LEFT JOIN Vlanlar v ON c.VlanId = v.Id
              WHERE c.CihazAdi LIKE @ara
                 OR c.IPAdresi LIKE @ara
                 OR c.CihazTipi LIKE @ara
                 OR c.Konum LIKE @ara
                 OR c.Durum LIKE @ara
                 OR v.VlanAdi LIKE @ara
                 OR CAST(v.VlanNo AS NVARCHAR) LIKE @ara",
                    baglanti);

                komut.Parameters.AddWithValue("@ara", "%" + kelime + "%");

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Cihaz
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CihazAdi = reader["CihazAdi"].ToString(),
                        IPAdresi = reader["IPAdresi"].ToString(),
                        CihazTipi = reader["CihazTipi"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Durum = reader["Durum"].ToString(),

                        VlanId = reader["VlanId"] == DBNull.Value
                            ? null
                            : Convert.ToInt32(reader["VlanId"]),

                        VlanBilgi = reader["VlanBilgi"].ToString()
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