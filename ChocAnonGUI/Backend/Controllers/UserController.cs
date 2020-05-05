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
    class UserController
    {
        public UserModel AddUser(UserModel user)
        {
            UserRepository userRepository = new UserRepository();
            do
            {
                user.UserNumber = NumberGenerator.Generate(9);
            }
            while (userRepository.GetUser(user.UserNumber).UserNumber != null);

            return userRepository.AddUser(user);
        }

        public UserModel GetUser(string userNumber)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.GetUser(userNumber);
        }

        public UserModel EditUser(UserModel user)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.EditUser(user);
        }

        public bool DeleteUser(string userNumber)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.DeleteUser(userNumber);
        }
    }
}
