using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.PageUtility;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace AutomationFramework.Pages
{
    public class BasePage:PageUtility
    {
        //public static IWebDriver driver;
        public void Begin()
        {
            //string browserName = ConfigurationManager.AppSettings["browser"];

            //if (browserName == "Chrome")
            //{
            //    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver("C:\\Users\\Nikku_Verma1\\source\\repos\\AutomationFramework\\LibraryProject\\Drivers\\chromedriver.exe");

            //}
            //else 
            //{
            //    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //    driver = new FirefoxDriver("C:\\Users\\Nikku_Verma1\\source\\repos\\AutomationFramework\\LibraryProject\\Drivers\\geckodriver.exe");
            //}
        }

        public void End()
        {
            driver.Close();
        }
    }
}
