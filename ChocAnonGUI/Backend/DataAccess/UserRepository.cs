using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.DataAccess
{
    class UserRepository
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=chocAnon; Integrated Security=SSPI");


        public bool LookUpUser(string userNumber)
        {
            try
            {
                string query = $"SELECT * FROM [user] WHERE userNumber = {userNumber}";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(); 
            }
        }
        public UserModel AddUser(UserModel user)
        {
            do
            {
                user.UserNumber = NumberGenerator.Generate(9);

            }
            while (LookUpUser(user.UserNumber));

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
    }
}
