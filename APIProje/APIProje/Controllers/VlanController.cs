using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VlanController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            try
            {
                List<VlanModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway, v.Konum, v.Aciklama, v.Renk,
                    COUNT(c.Id) AS CihazSayisi FROM Vlanlar v LEFT JOIN Cihazlar c ON c.VlanId = v.Id
                    GROUP BY v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway, v.Konum, v.Aciklama, v.Renk
                    ORDER BY v.VlanNo",
                    baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new VlanModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        VlanNo = Convert.ToInt32(reader["VlanNo"]),
                        VlanAdi = reader["VlanAdi"].ToString(),
                        Subnet = reader["Subnet"].ToString(),
                        Gateway = reader["Gateway"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Aciklama = reader["Aciklama"].ToString(),
                        Renk = reader["Renk"].ToString(),
                        CihazSayisi = Convert.ToInt32(reader["CihazSayisi"])
                    });
                }

                return Ok(liste);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Konum/{konum}")]
        public IActionResult KonumaGoreListele(string konum)
        {
            try
            {
                List<VlanModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway,
                     v.Konum, v.Aciklama, v.Renk,
                     COUNT(c.Id) AS CihazSayisi
              FROM Vlanlar v
              LEFT JOIN Cihazlar c ON c.VlanId = v.Id
              WHERE v.Konum = @konum
              GROUP BY v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway,
                       v.Konum, v.Aciklama, v.Renk
              ORDER BY v.VlanNo",
                    baglanti);

                komut.Parameters.AddWithValue("@konum", konum);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new VlanModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        VlanNo = Convert.ToInt32(reader["VlanNo"]),
                        VlanAdi = reader["VlanAdi"].ToString(),
                        Subnet = reader["Subnet"].ToString(),
                        Gateway = reader["Gateway"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Aciklama = reader["Aciklama"].ToString(),
                        Renk = reader["Renk"].ToString(),
                        CihazSayisi = Convert.ToInt32(reader["CihazSayisi"])
                    });
                }

                return Ok(liste);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Ara/{konum}/{kelime}")]
        public IActionResult KonumaGoreAra(string konum, string kelime)
        {
            try
            {
                List<VlanModel> liste = new();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"SELECT v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway,
                     v.Konum, v.Aciklama, v.Renk,
                     COUNT(c.Id) AS CihazSayisi
              FROM Vlanlar v
              LEFT JOIN Cihazlar c ON c.VlanId = v.Id
              WHERE v.Konum = @konum
                AND (
                    CAST(v.VlanNo AS NVARCHAR) LIKE @kelime
                    OR v.VlanAdi LIKE @kelime
                    OR v.Subnet LIKE @kelime
                    OR v.Gateway LIKE @kelime
                    OR v.Aciklama LIKE @kelime
                )
              GROUP BY v.Id, v.VlanNo, v.VlanAdi, v.Subnet, v.Gateway,
                       v.Konum, v.Aciklama, v.Renk
              ORDER BY v.VlanNo",
                    baglanti);

                komut.Parameters.AddWithValue("@konum", konum);
                komut.Parameters.AddWithValue("@kelime", "%" + kelime + "%");

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new VlanModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        VlanNo = Convert.ToInt32(reader["VlanNo"]),
                        VlanAdi = reader["VlanAdi"].ToString(),
                        Subnet = reader["Subnet"].ToString(),
                        Gateway = reader["Gateway"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Aciklama = reader["Aciklama"].ToString(),
                        Renk = reader["Renk"].ToString(),
                        CihazSayisi = Convert.ToInt32(reader["CihazSayisi"])
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
        public IActionResult Ekle([FromBody] VlanEkleModel data)
        {
            try
            {
                if (data.VlanNo < 1 || data.VlanNo > 4094)
                    return BadRequest("VLAN numarası 1-4094 arasında olmalıdır.");

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand(
                    @"SELECT COUNT(*) 
              FROM Vlanlar 
              WHERE VlanNo = @vlanNo AND Konum = @konum",
                    baglanti);

                kontrolKomut.Parameters.AddWithValue("@vlanNo", data.VlanNo);
                kontrolKomut.Parameters.AddWithValue("@konum", data.Konum);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                    return BadRequest("Bu ofiste aynı VLAN numarası zaten mevcut.");

                SqlCommand komut = new SqlCommand(
                    @"INSERT INTO Vlanlar
              (VlanNo, VlanAdi, Subnet, Gateway, Konum, Aciklama, Renk)
              VALUES
              (@vlanNo, @vlanAdi, @subnet, @gateway, @konum, @aciklama, @renk)",
                    baglanti);

                komut.Parameters.AddWithValue("@vlanNo", data.VlanNo);
                komut.Parameters.AddWithValue("@vlanAdi", data.VlanAdi);
                komut.Parameters.AddWithValue("@subnet", data.Subnet ?? "");
                komut.Parameters.AddWithValue("@gateway", data.Gateway ?? "");
                komut.Parameters.AddWithValue("@konum", data.Konum);
                komut.Parameters.AddWithValue("@aciklama", data.Aciklama ?? "");
                komut.Parameters.AddWithValue("@renk", data.Renk ?? "#3498DB");

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", "VLAN " + data.VlanNo + " - " + data.VlanAdi + " eklendi.");

                return Ok("VLAN eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Guncelle")]
        public IActionResult Guncelle([FromBody] VlanGuncelleModel data)
        {
            try
            {
                if (data.VlanNo < 1 || data.VlanNo > 4094)
                    return BadRequest("VLAN numarası 1-4094 arasında olmalıdır.");

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand(
                    @"SELECT COUNT(*) 
              FROM Vlanlar 
              WHERE VlanNo = @vlanNo 
                AND Konum = @konum
                AND Id <> @id",
                    baglanti);

                kontrolKomut.Parameters.AddWithValue("@vlanNo", data.VlanNo);
                kontrolKomut.Parameters.AddWithValue("@konum", data.Konum);
                kontrolKomut.Parameters.AddWithValue("@id", data.Id);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                    return BadRequest("Bu ofiste aynı VLAN numarası başka bir kayıtta mevcut.");

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Vlanlar
              SET VlanNo = @vlanNo,
                  VlanAdi = @vlanAdi,
                  Subnet = @subnet,
                  Gateway = @gateway,
                  Konum = @konum,
                  Aciklama = @aciklama,
                  Renk = @renk
              WHERE Id = @id",
                    baglanti);

                komut.Parameters.AddWithValue("@id", data.Id);
                komut.Parameters.AddWithValue("@vlanNo", data.VlanNo);
                komut.Parameters.AddWithValue("@vlanAdi", data.VlanAdi);
                komut.Parameters.AddWithValue("@subnet", data.Subnet ?? "");
                komut.Parameters.AddWithValue("@gateway", data.Gateway ?? "");
                komut.Parameters.AddWithValue("@konum", data.Konum);
                komut.Parameters.AddWithValue("@aciklama", data.Aciklama ?? "");
                komut.Parameters.AddWithValue("@renk", data.Renk ?? "#3498DB");

                komut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", "VLAN " + data.VlanNo + " - " + data.VlanAdi + " güncellendi.");

                return Ok("VLAN güncellendi.");
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

                SqlCommand cihazKontrolKomut = new SqlCommand(
                    "SELECT COUNT(*) FROM Cihazlar WHERE VlanId = @id",
                    baglanti);

                cihazKontrolKomut.Parameters.AddWithValue("@id", id);

                int cihazSayisi = Convert.ToInt32(cihazKontrolKomut.ExecuteScalar());

                if (cihazSayisi > 0)
                    return BadRequest("Bu VLAN'a bağlı cihazlar var. Önce cihazların VLAN bilgisini kaldırın veya değiştirin.");

                SqlCommand bilgiKomut = new SqlCommand(
                    "SELECT VlanNo, VlanAdi FROM Vlanlar WHERE Id = @id",
                    baglanti);

                bilgiKomut.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = bilgiKomut.ExecuteReader();

                if (!reader.Read())
                    return NotFound("VLAN bulunamadı.");

                int vlanNo = Convert.ToInt32(reader["VlanNo"]);
                string vlanAdi = reader["VlanAdi"].ToString();

                reader.Close();

                SqlCommand silKomut = new SqlCommand(
                    "DELETE FROM Vlanlar WHERE Id = @id",
                    baglanti);

                silKomut.Parameters.AddWithValue("@id", id);
                silKomut.ExecuteNonQuery();

                LogHelper log = new LogHelper();
                log.LogEkle("Sistem", "VLAN " + vlanNo + " - " + vlanAdi + " silindi.");

                return Ok("VLAN silindi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}