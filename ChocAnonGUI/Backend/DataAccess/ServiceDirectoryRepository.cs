using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChocAnonGUI.Backend.DataAccess
{
    class ServiceDirectoryRepository
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=chocAnon; Integrated Security=SSPI");

        public ServiceDirectoryModel GetService(string serviceCode)
        {
            try
            {
                string query = $"SELECT [serviceCode], cast([fee] as decimal(5, 2)), [name] FROM [service_directory] WHERE [serviceCode] = '{serviceCode}'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IDataRecord record = reader;

                    ServiceDirectoryModel service = new ServiceDirectoryModel
                    {
                        Code = (string)record[0],
                        Fee = (decimal)record[1],
                        Name = (string)record[2],
                    };
                    connection.Close();
                    return service;
                }
                else
                {
                    connection.Close();
                    return new ServiceDirectoryModel();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
                return new ServiceDirectoryModel();
            }
        }
        public ServiceDirectoryModel AddService(ServiceDirectoryModel service)
        {
            string query = $"INSERT INTO [service_directory] VALUES('{service.Code}', '{service.Fee}', '{service.Name}')";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                var result = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return service;
        }

        public ServiceDirectoryModel EditService(ServiceDirectoryModel service)
        {
            try
            {
                string query = $"UPDATE [service_directory] SET [fee] = '{service.Fee}', [name] = '{service.Name}'" +
                                $"WHERE [serviceCode] = '{service.Code}'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                return service;
            }
            catch (SqlException)
            {
                connection.Close();
                return new ServiceDirectoryModel();
            }
        }
    }
}
