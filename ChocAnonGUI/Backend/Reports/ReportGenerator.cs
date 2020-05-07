using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Linq.Mapping;
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
            string deleted = "DELETED";
            //For any service where the referenced member has been deleted. Display "DELETED"
            foreach (ServiceModel service in services)
            {
                report +=   $"Date of Service:  {service.ServiceDate.ToString("dd/MM/yyyy")}\n" +
                            $"Entry Date:       {service.EntryDate}\n" +
                            $"Member Name:      {service.Member.Name ?? deleted}\n" +
                            $"Member Number:    {service.Member.UserNumber ?? deleted}\n" +
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

        public string GenerateMemberReport(string memberNumber)
        {
            IEnumerable<ServiceModel> services = serviceRepository.GetServicesByMember(memberNumber);

            if (!services.Any())
            {
                return "No services to report in time range.";
            }

            UserModel member = services.First().Member;

            string report = $"MEMBER INFORMATION\n\n" +
                            $"Name:     {member.Name}\n" +
                            $"Number:   {member.UserNumber}\n" +
                            $"Address:  {member.StreetAddress}\n" +
                            $"City:     {member.City}\n" +
                            $"State:    {member.State}\n" +
                            $"Zip:      {member.Zip}\n" +
                            $"\n\n" +
                            $"SERVICES PROVIDED\n\n";

            string deleted = "DELETED";
            //For any service where the referenced provider has been deleted. Display "DELETED"
            foreach (ServiceModel service in services)
            {
                report +=   $"Date of Service:  {service.ServiceDate.ToString("dd/MM/yyyy")}\n" +
                            $"Provider Name:    {service.Provider.Name ?? deleted}\n" +
                            $"Service Name:     {service.ServiceDirectory.Name}\n" +
                            $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
            }

            string fileName = $"{member.Name} {DateTime.Now.ToString("MMMM dd yyyy")}";
            FileHandler.WriteMemberReport(report, fileName);

            return report;
        }

        public string GenerateSummaryReport()
        {
            var services = serviceRepository.GetServicesByEntryDate();
            
            if (!services.Any())
            {
                return "No services to report in time range.";
            }

            var providers = new Dictionary<string, ProviderSummary>();

            int uniqueProviders = 0;
            decimal totalFee = 0;

            foreach(var service in services)
            {
                var provider = service.Provider;
                var fee = service.ServiceDirectory.Fee;
                string deletedProviders = "DELETED";

                if(provider.UserNumber == null)
                {
                    //treat all deleted providers as a single unique provider
                    if (!providers.ContainsKey(deletedProviders))
                        {
                            providers[deletedProviders] = new ProviderSummary
                        {
                            ProviderName = deletedProviders,
                            TotalConsultations = 1,
                            TotalFee = fee
                        };
                        uniqueProviders++;
                    }
                    else
                    {
                        providers[deletedProviders].TotalConsultations++;
                        providers[deletedProviders].TotalFee += fee;
                    }

                }
                else if (!providers.ContainsKey(provider.UserNumber))
                {
                    //add new uniqye provider to map
                    providers[provider.UserNumber] = new ProviderSummary { ProviderName=provider.Name,
                                                                           TotalConsultations = 1,
                                                                           TotalFee = fee };
                    uniqueProviders++;
                }
                else
                {
                    //update values of existing provider in map
                    providers[provider.UserNumber].TotalConsultations++;
                    providers[provider.UserNumber].TotalFee += fee;
                }
                totalFee += fee;
            }
            string report = "PROVIDER SUMMARY\n\n";

            foreach(var provider in providers)
            {
                report +=   $"Provider Name:            {provider.Value.ProviderName}\n" +
                            $"Provider Number:          {provider.Key}\n" +
                            $"Number of Consultations:  {provider.Value.TotalConsultations}\n" +
                            $"Total Fee:                {provider.Value.TotalFee}\n" +
                            $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
            }

            report +=   $"\n\n" +
                        $"SUMMARY INFORMATION\n\n" +
                        $"Total Unique Providers:   {uniqueProviders}\n" +
                        $"Total Consultations:      {services.Count()}\n" +
                        $"Total Fee:                {totalFee}\n" +
                        $"\n\n";

            string fileName = $"{DateTime.Now.ToString("MMMM dd yyyy")}";
            FileHandler.WriteSummaryReport(report, fileName);

            return report;
        }
    }
}
