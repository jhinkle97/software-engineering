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

            foreach(ServiceModel service in services)
            {
                service.Member = member;
                service.Provider = userRepository.GetUser(service.Provider.UserNumber);
                service.ServiceDirectory = serviceDirectoryRepository.GetService(service.ServiceDirectory.Code);
            }
            return services;
        }
    }
}
