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
        private static readonly string managerPath = "ChocAn\\Reports\\Manager";
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
    }
}
