using CommonFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Configuration;

namespace CommonFramework.Utility
{
    public class UIUtility : BaseSetup
    {
        public static void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }

        public static bool DisplayedOrNot(By element)
        {
            return Driver.FindElement(element).Displayed;
        }

        public static void ClickOnElement(By element)
        {
            Driver.FindElement(element).Click();
        }

        public void ClickOnElementUsingJS(By element)
        {
            executor.ExecuteScript("arguments[0].click()", Driver.FindElement(element));
        }

        public static void ClickOnElements(By element)
        {
            ReadOnlyCollection<IWebElement> webElements = Driver.FindElements(element);
            foreach (IWebElement webElement in webElements)
            {
                webElement.Click();
            }
        }

        public static void SendKeysToField(By element, string text)
        {
            Driver.FindElement(element).SendKeys(text);
        }

        public static string GetURL()
        {
            return Driver.Url;
        }

        public static By GetByXPathElementById(string id)
        {
            return By.XPath($"//input[@id='{id}']");
        }

        public static By GetByXPathElementForCommonPartOfClass(string commonPartValue, string differentPartValue)
        {
            return By.XPath($"//input[@class='{commonPartValue}+{differentPartValue}']");
        }

        public static Dictionary<string,string> MakeDictionary(By key, By value)
        {
            int keyCount = 0, valueCount = 0;
            ReadOnlyCollection<IWebElement> keys = Driver.FindElements(key);
            ReadOnlyCollection<IWebElement> values = Driver.FindElements(value);
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
