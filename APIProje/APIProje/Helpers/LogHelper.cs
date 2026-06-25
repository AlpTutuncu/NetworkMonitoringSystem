using Microsoft.Data.SqlClient;

namespace APIProje
{
    public class LogHelper
    {
        private readonly string connStr =
            @"Server=.\SQLEXPRESS;Database=APIProjeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public void LogEkle(string kullanici, string islem)
        {
            using SqlConnection baglanti = new SqlConnection(connStr);
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                @"INSERT INTO IslemLog (Kullanici, Islem)
                  VALUES (@kullanici, @islem)",
                baglanti);

            komut.Parameters.AddWithValue("@kullanici", kullanici);
            komut.Parameters.AddWithValue("@islem", islem);

            komut.ExecuteNonQuery();
        }
    }
}