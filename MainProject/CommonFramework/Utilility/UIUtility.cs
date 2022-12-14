using CommonFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CommonFramework.Utility
{
    public class UIUtility : BaseClass
    {
        public static void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public static void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }
        public void ClickOnElementUsingJS(By element)
        {
            executor.ExecuteScript("arguments[0].click()", driver.FindElement(element));
        }
        public static void ClickOnElements(By element)
        {
            ReadOnlyCollection<IWebElement> webElements = driver.FindElements(element);
            foreach (IWebElement webElement in webElements)
            {
                webElement.Click();
            }
        }
        public static void SendKeysToField(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }
        public static string GetURL()
        {
            return driver.Url;
        }
        public static Dictionary<string,string> MakeDictionary(By key, By value)
        {
            int keyCount = 0, valueCount = 0;
            ReadOnlyCollection<IWebElement> keys = driver.FindElements(key);
            ReadOnlyCollection<IWebElement> values = driver.FindElements(value);
            Dictionary<string,string> result = new Dictionary<string,string>();            
            foreach (IWebElement keyElement in keys)
            {
                keyCount++;
                foreach (IWebElement valueElement in values)
                {
                    valueCount++;
                    if (keyCount == valueCount)
                    {
                        result.Add(keyElement.Text, valueElement.Text);
                        valueCount = 0;
                        break;
                    }
                    
                }                                
            }
            return result;
        }
    }
}
