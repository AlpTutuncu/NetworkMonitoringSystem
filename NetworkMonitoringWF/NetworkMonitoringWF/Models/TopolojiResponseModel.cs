using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoringWF.Models
{
    public class TopolojiResponseModel
    {
        public List<TopolojiNodeModel> Nodes { get; set; }
        public List<TopolojiLinkModel> Links { get; set; }
    }
}
