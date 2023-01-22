using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Selenium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firefox Driver: 1 /n" +
                "Chrome Driver: 2");
            var value=Console.ReadLine();
            int result=Convert.ToInt32(value);
            if(result==1) 
            {
                DriversType.FirefoxDriver();
            }
            else
            {
                DriversType.ChromeDriver();
            }
        }
    }
}
