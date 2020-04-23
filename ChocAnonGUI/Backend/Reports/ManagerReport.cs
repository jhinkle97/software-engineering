using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Reports
{
    class ManagerReport
    {
        public IEnumerable<ServiceModel> Services{ get; set; }
        public IEnumerable<ProviderSummary> Providers { get; set; }
        public int TotalFee { get; set; }
        public int TotalConsultations { get; set; }
        public int TotalUniqueProviders { get; set; }
    }
}
