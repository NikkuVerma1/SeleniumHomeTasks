using LibraryProject.Utilities.PageUtility;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.ExtensionMethods
{
    public static class WebDriverWaitExtension
    {
        static WebDriverWait wait;
        public static WebDriverWait LongerWait(this WebDriverWait webDriverWait)
        {
            wait = new WebDriverWait(PageUtility.driver, TimeSpan.FromSeconds(60));
            return wait;
        }

        public static WebDriverWait ShorterWait(this WebDriverWait webDriverWait)
        {
            wait=new WebDriverWait(PageUtility.driver, TimeSpan.FromSeconds(10));
            return wait;
        }
    }
}
