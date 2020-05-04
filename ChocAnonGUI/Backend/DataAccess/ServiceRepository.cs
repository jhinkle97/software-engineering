using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.DataAccess
{
    class ServiceRepository
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=chocAnon; Integrated Security=SSPI");

        public bool AddService(ServiceModel service)
        {
            string query = $"INSERT INTO [service] VALUES('{service.EntryDate}', '{service.ServiceDate}', '{service.Provider.UserNumber}', " +
                                                        $"'{service.Member.UserNumber}', '{service.ServiceDirectory.Code}', '{service.Comments}')";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                var result = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
                return false;
            }
            return true;
        }

        public IEnumerable<ServiceModel> GetServicesByMember(string memberNumber)
        {
            try
            {
                string query = $"SELECT * FROM [service] WHERE [memberNumber] = '{memberNumber}'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                List<ServiceModel> services = new List<ServiceModel>();

                while (reader.Read())
                {
                    IDataRecord record = reader;

                    ServiceModel service = new ServiceModel
                    {
                        EntryDate = (DateTime)record[1],
                        ServiceDate = (DateTime)record[2],
                        Provider = new UserModel { UserNumber=(string)record[3] },
                        Member = new UserModel { UserNumber=(string)record[4] },
                        ServiceDirectory = new ServiceDirectoryModel { Code=(string)record[5] },
                        Comments = (string)record[6]
                    };
                    services.Add(service);
                }
                connection.Close();
                return services;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
                return new List<ServiceModel>();
            }
        }
    }
}
