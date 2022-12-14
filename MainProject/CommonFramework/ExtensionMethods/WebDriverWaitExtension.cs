using CommonFramework.Utility;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.ExtensionMethods
{
    public static class WebDriverWaitExtension
    {
        static WebDriverWait wait;
        public static WebDriverWait LongerWait(this WebDriverWait webDriverWait)
        {
            wait = new WebDriverWait(UIUtility.driver, TimeSpan.FromSeconds(Double.Parse(ConfigurationManager.AppSettings["longerWait"])));
            return wait;
        }

        public static WebDriverWait ShorterWait(this WebDriverWait webDriverWait)
        {
            wait = new WebDriverWait(UIUtility.driver, TimeSpan.FromSeconds(Double.Parse(ConfigurationManager.AppSettings["shorterWait"])));
            return wait;
        }
    }
}
