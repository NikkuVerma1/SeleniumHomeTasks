using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Utilities.PageUtility;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace LibraryProject
{
    public class BaseClass : PageUtility
    {
        //public static IWebDriver driver;
        string browserName;
        public void Begin()
        {
            browserName = ConfigurationManager.AppSettings["browser"];
            if (browserName == "Chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }
            else
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            }
        }

        public void End()
        {
            driver.Close();
        }
    }
}
