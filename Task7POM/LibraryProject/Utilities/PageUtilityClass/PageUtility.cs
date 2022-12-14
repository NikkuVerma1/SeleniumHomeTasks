using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Utilities.PageUtility
{
    public class PageUtility
    {
        public static IWebDriver driver;
        protected IJavaScriptExecutor executor => (IJavaScriptExecutor)driver;
        protected WebDriverWait wait;

        public static void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public static void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public static void  ClickOnOneOfElements(By element, string item)
        {
            IReadOnlyCollection<IWebElement> webElements = driver.FindElements(element);
            foreach (IWebElement webElement in webElements)
            {
                if (webElement.Text.Equals(item))
                {
                    webElement.Click();
                    break;
                }
            }
        }
        public void ClickOnElementUsingJS(By element)
        {
            executor.ExecuteScript("arguments[0].click()", driver.FindElement(element));
        }
        public static void SendKeysToField(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public static IReadOnlyCollection<IWebElement> GetWebElements(By element)
        {
            return driver.FindElements(element);
        }
        
        public string[] StringSplit(By element)
        {
            return driver.FindElement(element).Text.Split(' ');
        }
    }
}
