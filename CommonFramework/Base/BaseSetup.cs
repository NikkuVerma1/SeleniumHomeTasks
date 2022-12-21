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
    public class BaseSetup
    {
        public static IWebDriver Driver { get; set; }       
        protected IJavaScriptExecutor executor => (IJavaScriptExecutor)Driver;
        protected WebDriverWait wait;
        public static ExtentReport extentReport = new ExtentReport();
        string browserName;

        public static string GetAppConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public void InvokeBrowser()
        {
            extentReport.ExtentStart();
            browserName = GetAppConfigValue("browser");
            if (browserName == "Chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                Driver = new ChromeDriver();

            }
            else
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                Driver = new FirefoxDriver();
            }
        }

        public void CloseBrowser()
        {
            extentReport.ExtentClose();
            Driver.Close();
        }
    }
}