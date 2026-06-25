using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class PingSonucModel
    {
        public string CihazAdi { get; set; }
        public string IpAdresi { get; set; }
        public string Durum { get; set; }
        public long Gecikme { get; set; }
    }
}
