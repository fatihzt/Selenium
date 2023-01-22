using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium
{
    public static class DriversType
    {
        public static void ChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://lms.antalya.edu.tr/login/index.php");
            driver.Manage().Window.Maximize();
            Console.WriteLine("We navigate to lms system with chrome driver.");
            IWebElement usernameTextBox = driver.FindElement(By.Name("username"));
            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            IWebElement loginButton = driver.FindElement(By.CssSelector(".btn.btn-primary.btn-block.mt-3"));

            usernameTextBox.SendKeys(UserInformation.Username);
            passwordTextBox.SendKeys(UserInformation.Password);

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".btn.btn-primary.btn-block.mt-3")));
            loginButton.Click();
            Console.WriteLine("Main page load");

            IWebElement announcement = driver.FindElement(By.CssSelector("a[title='Duyurular']"));
            announcement.Click();


            driver.Navigate().Back();
            IWebElement mainpageButton = driver.FindElement(By.CssSelector(".navbar-brand.has-logo"));
            mainpageButton.Click();
            IWebElement searchTextBox = driver.FindElement(By.CssSelector("input[id='shortsearchbox']"));
            searchTextBox.SendKeys("CS");
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            searchButton.Click();

            IWebElement nameBox = driver.FindElement(By.CssSelector(".dropdown"));
            nameBox.Click();
            IWebElement closeButton = driver.FindElement(By.CssSelector("a[data-title='logout,moodle']"));
            closeButton.Click();


        }
        public static void FirefoxDriver()
        {
            String driverPath = @"C:\\Users\\user\\Desktop\\driver\\geckodriver.exe";
            IWebDriver driver = new FirefoxDriver(driverPath);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://lms.antalya.edu.tr/login/index.php");
            driver.Manage().Window.Maximize();


            Console.WriteLine("We navigate to lms system with firefox driver.");

            IWebElement usernameTextBox = driver.FindElement(By.Name("username"));
            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            IWebElement loginButton = driver.FindElement(By.CssSelector(".btn.btn-primary.btn-block.mt-3"));

            usernameTextBox.SendKeys(UserInformation.Username);
            passwordTextBox.SendKeys(UserInformation.Password);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".btn.btn-primary.btn-block.mt-3")));
            loginButton.Click();
            Console.WriteLine("Main page load");

            IWebElement news = driver.FindElement(By.CssSelector("a[title='Haberler']"));
            news.Click();

            driver.Navigate().Back();

            IWebElement mainpageButton = driver.FindElement(By.CssSelector(".navbar-brand.has-logo"));
            mainpageButton.Click();
            IWebElement searchTextBox = driver.FindElement(By.CssSelector("input[id='shortsearchbox']"));
            searchTextBox.SendKeys("CS");
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            searchButton.Click();

            IWebElement nameBox = driver.FindElement(By.CssSelector(".dropdown"));
            nameBox.Click();
            IWebElement closeButton = driver.FindElement(By.CssSelector("a[data-title='logout,moodle']"));
            closeButton.Click();


        }

    }
}
