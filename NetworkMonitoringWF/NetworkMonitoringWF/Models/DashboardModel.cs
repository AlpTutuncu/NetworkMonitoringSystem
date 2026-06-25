using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class DashboardModel
    {
        public int ToplamCihaz { get; set; }
        public int AktifCihaz { get; set; }
        public int PasifCihaz { get; set; }
        public int BilinmeyenCihaz { get; set; }
        public string SonKontrolZamani { get; set; }
        public string SonIslem { get; set; }
        public bool PingServisAktifMi { get; set; }
    }
}
