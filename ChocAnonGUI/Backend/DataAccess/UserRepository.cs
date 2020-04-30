using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.DataAccess
{
    class UserRepository
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=chocAnon; Integrated Security=SSPI");


        public UserModel GetUser(string userNumber)
        {
            try
            {
                string query = $"SELECT * FROM [user] WHERE [userNumber] = '{userNumber}'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IDataRecord record = reader;

                    UserModel user = new UserModel
                    {
                        Role = (string)record[1],
                        Status = (string)record[2],
                        Name = (string)record[3],
                        UserNumber = (string)record[4],
                        StreetAddress = (string)record[5],
                        City = (string)record[6],
                        State = (string)record[7],
                        Zip = (string)record[8]
                    };
                    connection.Close();
                    return user;
                }
                else
                {
                    connection.Close();
                    return new UserModel();
                }
            }
            catch (SqlException)
            {
                connection.Close();
                return new UserModel();
            }
        }
        public UserModel AddUser(UserModel user)
        {
            do
            {
                user.UserNumber = NumberGenerator.Generate(9);

            }
            while (GetUser(user.UserNumber).UserNumber != null);

            string query = $"INSERT INTO [user] VALUES('{user.Role}', '{user.Status}', '{user.Name}', '{user.UserNumber}', " +
                                                    $"'{user.StreetAddress}', '{user.City}', '{user.State}', '{user.Zip}')";

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
            return user;
        }

        public UserModel EditUser(UserModel user)
        {
            try
            {
                string query = $"UPDATE [user] SET [role] = '{user.Role}', [status] = '{user.Status}', [name] = '{user.Name}', " +
                               $"[userNumber] = '{user.UserNumber}', [streetAddress] = '{user.StreetAddress}', " +
                               $"[city] = '{user.City}', [state] = '{user.State}', [zip] = '{user.Zip}' " +
                               $"WHERE [userNumber] = '{user.UserNumber}'";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                return user;
            }
            catch (SqlException)
            {
                connection.Close();
                return new UserModel();
            }
        }
    }
}
