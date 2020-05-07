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

            //Generate random 6 digit code and check that it does not already exist in DB
            do
            {
                service.Code = NumberGenerator.Generate(6);
            }
            while (serviceDirectoryRepository.GetService(service.Code).Code != null);

            service = serviceDirectoryRepository.AddService(service);

            //Write service directory file every time a service is updated
            FileHandler.WriteServiceDirectory();

            return service;
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

            service = serviceDirectoryRepository.EditService(service);

            //Write service directory file every time a service is updated
            FileHandler.WriteServiceDirectory();

            return service;
        }

        public bool DeleteService(string serviceCode)
        {
            ServiceDirectoryRepository serviceDirectoryRepository = new ServiceDirectoryRepository();
            
            var isDeleted = serviceDirectoryRepository.DeleteService(serviceCode);

            //Write service directory file every time a service is updated
            FileHandler.WriteServiceDirectory();

            return isDeleted;
        }
    }
}
