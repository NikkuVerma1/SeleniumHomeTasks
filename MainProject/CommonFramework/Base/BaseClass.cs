using CommonFramework.Reports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace CommonFramework.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        protected IJavaScriptExecutor executor => (IJavaScriptExecutor)driver;
        protected WebDriverWait wait;
        public static ExtentReport extentReport = new ExtentReport();
        string browserName;

        public void Begin()
        {
            extentReport.ExtentStart();
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
        //public static void NavigateToURL(string url)
        //{
        //    driver.Navigate().GoToUrl(url);
        //    driver.Manage().Window.Maximize();
        //}

        public void End()
        {
            extentReport.ExtentClose();
            driver.Close();
        }
    }
}