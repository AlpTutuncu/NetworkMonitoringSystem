using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class RaporModel
    {
        public DateTime RaporTarihi { get; set; }

        public int ToplamCihaz { get; set; }
        public int AktifCihaz { get; set; }
        public int PasifCihaz { get; set; }
        public int BilinmeyenCihaz { get; set; }

        public int ToplamVlan { get; set; }

        public List<string> SonAlarmlar { get; set; }
        public List<string> SonIslemler { get; set; }
        public List<string> SonPingler { get; set; }
    }
}
