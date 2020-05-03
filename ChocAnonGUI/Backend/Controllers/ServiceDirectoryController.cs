using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Controllers
{
    class ServiceDirectoryController
    {
        public ServiceDirectoryModel AddService(ServiceDirectoryModel service)
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            do
            {
                service.Code = NumberGenerator.Generate(6);
            }
            while (serviceDirectoryRepository.GetService(service.Code).Code != null);

            return serviceDirectoryRepository.AddService(service);
        }

        public ServiceDirectoryModel GetService(string serviceCode)
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            return serviceDirectoryRepository.GetService(serviceCode);
        }

        public IEnumerable<ServiceDirectoryModel> GetServices()
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            return serviceDirectoryRepository.GetServices();
        }

        public ServiceDirectoryModel EditService(ServiceDirectoryModel service)
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            return serviceDirectoryRepository.EditService(service);
        }

        public bool DeleteService(string serviceCode)
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            return serviceDirectoryRepository.DeleteService(serviceCode);
        }
    }
}
