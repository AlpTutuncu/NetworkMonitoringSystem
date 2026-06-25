using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class CihazModel
    {
        public int Id { get; set; }
        public string CihazAdi { get; set; }
        public string IPAdresi { get; set; }
        public string CihazTipi { get; set; }
        public string Konum { get; set; }
        public string Durum { get; set; }
        public int? VlanId { get; set; }
        public string VlanBilgi { get; set; }
    }
}
