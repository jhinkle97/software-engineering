using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Reports
{
    class ReportGenerator
    {
        private ServiceController serviceRepository = new ServiceController();
        public string GenerateProviderReport(string providerNumber)
        {
            IEnumerable<ServiceModel> services = serviceRepository.GetServicesByProvider(providerNumber);

            if (!services.Any())
            {
                return "No services to report in time range.";
            }

            UserModel provider = services.First().Provider;

            string report = $"PROVIDER INFORMATION\n\n" +
                            $"Name:     {provider.Name}\n" +
                            $"Number:   {provider.UserNumber}\n" +
                            $"Address:  {provider.StreetAddress}\n" +
                            $"City:     {provider.City}\n" +
                            $"State:    {provider.State}\n" +
                            $"Zip:      {provider.Zip}\n" +
                            $"\n\n" +
                            $"SERVICES PROVIDED\n\n";

            decimal totalFee = 0;

            foreach(ServiceModel service in services)
            {
                report += $"Date of Service:  {service.ServiceDate}\n" +
                            $"Entry Date:       {service.EntryDate}\n" +
                            $"Member Name:      {service.Member.Name}\n" +
                            $"Member Number:    {service.Member.UserNumber}\n" +
                            $"Service Code:     {service.ServiceDirectory.Code}\n" +
                            $"Service Fee:      {service.ServiceDirectory.Fee}\n" +
                            $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";

                totalFee += service.ServiceDirectory.Fee;
            }

            report +=   $"\n\n" +
                        $"SUMMARY INFORMATION\n\n" +
                        $"Total Consultations:  {services.Count()}\n" +
                        $"Total Fee:            {totalFee}\n" +
                        $"\n\n";

            string fileName = $"{provider.Name} {DateTime.Now.ToString("MMMM dd yyyy")}";
            FileHandler.WriteProviderReport(report, fileName);

            return report;
        }
    }
}
