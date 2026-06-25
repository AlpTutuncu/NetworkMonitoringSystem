using APIProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APIProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopolojiController : ControllerBase
    {
        string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        [HttpGet]
        public IActionResult Getir()
        {
            try
            {
                TopolojiResponseModel response = new();
                response.Nodes = new List<TopolojiNodeModel>();
                response.Links = new List<TopolojiLinkModel>();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand nodeKomut = new SqlCommand(
                    @"SELECT Id,CihazAdi,IPAdresi,CihazTipi,
                             Konum,Durum,PosX,PosY
                      FROM Cihazlar",
                    baglanti);

                SqlDataReader reader = nodeKomut.ExecuteReader();

                while (reader.Read())
                {
                    response.Nodes.Add(new TopolojiNodeModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CihazAdi = reader["CihazAdi"].ToString(),
                        IPAdresi = reader["IPAdresi"].ToString(),
                        CihazTipi = reader["CihazTipi"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        PosX = Convert.ToDouble(reader["PosX"]),
                        PosY = Convert.ToDouble(reader["PosY"])
                    });
                }

                reader.Close();

                SqlCommand linkKomut = new SqlCommand(
                    @"SELECT FromCihazId, ToCihazId
                      FROM CihazBaglantilari",
                    baglanti);

                reader = linkKomut.ExecuteReader();

                while (reader.Read())
                {
                    response.Links.Add(new TopolojiLinkModel
                    {
                        FromCihazId = Convert.ToInt32(reader["FromCihazId"]),
                        ToCihazId = Convert.ToInt32(reader["ToCihazId"])
                    });
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("BaglantiEkle")]
        public IActionResult BaglantiEkle([FromBody] BaglantiEkleModel data)
        {
            try
            {
                if (data.FromCihazId == data.ToCihazId)
                    return BadRequest("Bir cihaz kendisine bağlanamaz.");

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand(
                    @"SELECT COUNT(*) 
              FROM CihazBaglantilari
              WHERE (FromCihazId=@from AND ToCihazId=@to)
                 OR (FromCihazId=@to AND ToCihazId=@from)",
                    baglanti);

                kontrolKomut.Parameters.AddWithValue("@from", data.FromCihazId);
                kontrolKomut.Parameters.AddWithValue("@to", data.ToCihazId);

                int varMi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (varMi > 0)
                    return BadRequest("Bu bağlantı zaten var.");

                SqlCommand ekleKomut = new SqlCommand(
                    @"INSERT INTO CihazBaglantilari (FromCihazId, ToCihazId)
              VALUES (@from, @to)",
                    baglanti);

                ekleKomut.Parameters.AddWithValue("@from", data.FromCihazId);
                ekleKomut.Parameters.AddWithValue("@to", data.ToCihazId);

                ekleKomut.ExecuteNonQuery();

                return Ok("Bağlantı eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("BaglantiSil/{fromId}/{toId}")]
        public IActionResult BaglantiSil(int fromId, int toId)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"DELETE FROM CihazBaglantilari
              WHERE (FromCihazId=@from AND ToCihazId=@to)
                 OR (FromCihazId=@to AND ToCihazId=@from)",
                    baglanti);

                komut.Parameters.AddWithValue("@from", fromId);
                komut.Parameters.AddWithValue("@to", toId);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                    return Ok("Bağlantı silindi.");

                return NotFound("Bağlantı bulunamadı.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Konum/{konum}")]
        public IActionResult KonumaGoreGetir(string konum)
        {
            try
            {
                TopolojiResponseModel response = new();
                response.Nodes = new List<TopolojiNodeModel>();
                response.Links = new List<TopolojiLinkModel>();

                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand nodeKomut = new SqlCommand(
                    @"SELECT c.Id, c.CihazAdi, c.IPAdresi, c.CihazTipi,
             c.Konum, c.Durum, c.PosX, c.PosY,
             c.VlanId,
             CASE 
                 WHEN v.Id IS NULL THEN '-'
                 ELSE CAST(v.VlanNo AS NVARCHAR) + ' - ' + v.VlanAdi
             END AS VlanBilgi
      FROM Cihazlar c
      LEFT JOIN Vlanlar v ON c.VlanId = v.Id
      WHERE c.Konum = @konum",
                    baglanti);

                nodeKomut.Parameters.AddWithValue("@konum", konum);

                SqlDataReader reader = nodeKomut.ExecuteReader();

                while (reader.Read())
                {
                    response.Nodes.Add(new TopolojiNodeModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CihazAdi = reader["CihazAdi"].ToString(),
                        IPAdresi = reader["IPAdresi"].ToString(),
                        CihazTipi = reader["CihazTipi"].ToString(),
                        Konum = reader["Konum"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        PosX = Convert.ToDouble(reader["PosX"]),
                        PosY = Convert.ToDouble(reader["PosY"]),
                        VlanId = reader["VlanId"] == DBNull.Value? null: Convert.ToInt32(reader["VlanId"]),
                        VlanBilgi = reader["VlanBilgi"].ToString()
                    });
                }

                reader.Close();

                SqlCommand linkKomut = new SqlCommand(
                    @"SELECT b.FromCihazId, b.ToCihazId
              FROM CihazBaglantilari b
              INNER JOIN Cihazlar c1 ON b.FromCihazId = c1.Id
              INNER JOIN Cihazlar c2 ON b.ToCihazId = c2.Id
              WHERE c1.Konum = @konum AND c2.Konum = @konum",
                    baglanti);

                linkKomut.Parameters.AddWithValue("@konum", konum);

                reader = linkKomut.ExecuteReader();

                while (reader.Read())
                {
                    response.Links.Add(new TopolojiLinkModel
                    {
                        FromCihazId = Convert.ToInt32(reader["FromCihazId"]),
                        ToCihazId = Convert.ToInt32(reader["ToCihazId"])
                    });
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("KonumGuncelle/{cihazId}")]
        public IActionResult KonumGuncelle(int cihazId, [FromBody] KonumGuncelleModel data)
        {
            try
            {
                using SqlConnection baglanti = new SqlConnection(connStr);
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Cihazlar
              SET PosX = @x,
                  PosY = @y
              WHERE Id = @id",
                    baglanti);

                komut.Parameters.AddWithValue("@x", data.PosX);
                komut.Parameters.AddWithValue("@y", data.PosY);
                komut.Parameters.AddWithValue("@id", cihazId);

                komut.ExecuteNonQuery();

                return Ok("Konum güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}