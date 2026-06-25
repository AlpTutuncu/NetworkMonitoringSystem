namespace APIProje.Models
{
    public class CihazGuncelleModel
    {
        public int Id { get; set; }
        public string CihazAdi { get; set; }
        public string IPAdresi { get; set; }
        public string CihazTipi { get; set; }
        public string Konum { get; set; }
        public int? VlanId { get; set; }
    }
}
