using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class UserInformation 
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        static UserInformation()
        {
            Username = "username";
            Password = "password";
        }

    }
}
