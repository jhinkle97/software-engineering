using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Models;
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
    }
}
