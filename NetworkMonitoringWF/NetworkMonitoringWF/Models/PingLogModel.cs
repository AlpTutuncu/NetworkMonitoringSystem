using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class PingLogModel
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string CihazAdi { get; set; }
        public string IPAdresi { get; set; }
        public string Durum { get; set; }
        public DateTime KontrolTarihi { get; set; }
    }
}
