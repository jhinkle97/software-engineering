using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocAnonGUI.Backend.Utilities
{
    public static class NumberGenerator
    {
        public static string Generate(int numberOfDigits)
        {
            //used for generating user numbers and service codes
            Random random = new Random();
            string number = "";
            int i;
            for (i = 0; i < numberOfDigits; i++)
            {
                number += random.Next(0, 9).ToString();
            }
            return number;
        }
    }
}
