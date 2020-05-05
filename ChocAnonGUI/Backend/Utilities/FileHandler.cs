using ChocAnonGUI.Backend.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Utilities
{
    class FileHandler
    {
        private static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static readonly string providerPath = "ChocAn\\Reports\\Provider";
        private static readonly string memberPath = "ChocAn\\Reports\\Member";
        private static readonly string summaryPath = "ChocAn\\Reports\\Summary";
        private static readonly string serviceDirectoryPath = "ChocAn";

        public static void WriteProviderReport(string report, string fileName)
        {
            string path = $"{desktopPath}\\{providerPath}";
            
            Directory.CreateDirectory(path);

            StreamWriter file = new StreamWriter($"{path}\\{fileName}.txt");
            {
                file.WriteLine(report);
            }
            file.Close();
        }

        public static void WriteSummaryReport(string report, string fileName)
        {
            string path = $"{desktopPath}\\{summaryPath}";

            Directory.CreateDirectory(path);

            StreamWriter file = new StreamWriter($"{path}\\{fileName}.txt");
            {
                file.WriteLine(report);
            }
            file.Close();
        }

        public static void WriteServiceDirectory()
        {
            string path = $"{desktopPath}\\{serviceDirectoryPath}";

            Directory.CreateDirectory(path);

            var serviceDirectoryRepository = new ServiceDirectoryRepository();

            var services = serviceDirectoryRepository.GetServices();

            string service_directory = "SERVICE DIRECTORY\n\n";
            foreach (var service in services)
            {
                service_directory +=    $"Service Name: {service.Name}\n" +
                                        $"Service Code: {service.Code}\n" +
                                        $"Service Fee:  {service.Fee}\n" +
                                        $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
            }

            StreamWriter file = new StreamWriter($"{path}\\service_directory.txt");
            {
                
                file.WriteLine(service_directory);
            }
            file.Close();
        }
    }
}
