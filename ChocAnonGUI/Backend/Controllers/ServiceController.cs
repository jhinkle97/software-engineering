using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Controllers
{
    class ServiceController
    {
        public bool AddService(ServiceModel service)
        {
            ServiceRepository serviceRepository = new ServiceRepository();
            service.EntryDate = DateTime.Now;
            return serviceRepository.AddService(service);
        }

        public IEnumerable<ServiceModel> GetServicesByMember(string memberNumber)
        {
            ServiceRepository serviceRepository = new ServiceRepository();
            UserRepository userRepository = new UserRepository();
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();

            IEnumerable<ServiceModel> services = serviceRepository.GetServicesByMember(memberNumber);
            UserModel member = userRepository.GetUser(memberNumber);

            //Services in the database contain the number or code to reference, member, provider, service directory
            //Here we bring back the corresponding model for each reference on every service
            foreach(ServiceModel service in services)
            {
                service.Member = member;
                service.Provider = userRepository.GetUser(service.Provider.UserNumber);
                service.ServiceDirectory = serviceDirectoryRepository.GetService(service.ServiceDirectory.Code);
            }
            return services;
        }

        public IEnumerable<ServiceModel> GetServicesByProvider(string providerNumber)
        {
            ServiceRepository serviceRepository = new ServiceRepository();
            UserRepository userRepository = new UserRepository();
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();

            IEnumerable<ServiceModel> services = serviceRepository.GetServicesByProvider(providerNumber);
            UserModel provider = userRepository.GetUser(providerNumber);

            //Services in the database contain the number or code to reference, member, provider, service directory
            //Here we bring back the corresponding model for each reference on every service
            foreach (ServiceModel service in services)
            {
                service.Provider = provider;
                service.Member = userRepository.GetUser(service.Member.UserNumber);
                service.ServiceDirectory = serviceDirectoryRepository.GetService(service.ServiceDirectory.Code);
            }
            return services;
        }

        public IEnumerable<ServiceModel> GetServicesByEntryDate()
        {
            ServiceRepository serviceRepository = new ServiceRepository();
            UserRepository userRepository = new UserRepository();
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();

            IEnumerable<ServiceModel> services = serviceRepository.GetServicesByEntryDate();

            //Services in the database contain the number or code to reference, member, provider, service directory
            //Here we bring back the corresponding model for each reference on every service
            foreach (ServiceModel service in services)
            {
                service.Provider = userRepository.GetUser(service.Provider.UserNumber);
                service.Member = userRepository.GetUser(service.Member.UserNumber);
                service.ServiceDirectory = serviceDirectoryRepository.GetService(service.ServiceDirectory.Code);
            }
            return services;
        }
    }
}
