using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Reports
{
    class ProviderSummary
    {
        public string ProviderName { get; set; }
        public decimal TotalFee { get; set; }
        public int TotalConsultations { get; set; }
    }
}
