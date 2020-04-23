using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Models
{
    class ServiceModel
    {
        public DateTime EntryDate { get; set; }
        public DateTime ServiceDate { get; set; }
        public UserModel Member { get; set; }
        public UserModel Provider { get; set; }
        public ServiceDirectoryModel ServiceDirectory { get; set; }
        public string Comments { get; set; }

    }
}
