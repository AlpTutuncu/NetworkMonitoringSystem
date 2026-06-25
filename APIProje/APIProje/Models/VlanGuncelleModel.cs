namespace APIProje.Models
{
    public class VlanGuncelleModel
    {
        public int Id { get; set; }
        public int VlanNo { get; set; }
        public string VlanAdi { get; set; }
        public string Subnet { get; set; }
        public string Gateway { get; set; }
        public string Konum { get; set; }
        public string Aciklama { get; set; }
        public string Renk { get; set; }
    }
}
