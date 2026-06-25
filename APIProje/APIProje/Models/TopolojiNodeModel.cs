namespace APIProje.Models
{
    public class TopolojiNodeModel
    {
        public int Id { get; set; }
        public string CihazAdi { get; set; }
        public string IPAdresi { get; set; }
        public string CihazTipi { get; set; }
        public string Konum { get; set; }
        public string Durum { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public int? VlanId { get; set; }
        public string VlanBilgi { get; set; }
    }
}
