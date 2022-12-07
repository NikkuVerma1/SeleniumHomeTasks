using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities.PageUtility
{
    public class PageUtility
    {
        protected static IWebDriver driver;
        protected IJavaScriptExecutor executor => (IJavaScriptExecutor)driver;
        protected WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public void NavigateToURl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }
        public void ClickOnElementUsingJS(By element)
        {
            executor.ExecuteScript("arguments[0].click()", driver.FindElement(element));
        }
        public void SendKeysToField(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }
       
    }
}
