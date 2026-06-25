using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    internal class AlarmBildirimModel
    {
        public int Id { get; set; }
        public int CihazId { get; set; }
        public string CihazAdi { get; set; }
        public string IPAdresi { get; set; }
        public string EskiDurum { get; set; }
        public string YeniDurum { get; set; }
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
        public bool OkunduMu { get; set; }
    }
}
