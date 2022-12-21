using CommonFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Configuration;
using OpenQA.Selenium.Interactions;
using CommonFramework.ExtensionMethods;
using SeleniumExtras.WaitHelpers;

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
        public static IReadOnlyCollection<IWebElement> GetMultipleElements(By element)
        {
            return Driver.FindElements(element);
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

        public static string GetText(By element)
        {
            return Driver.FindElement(element).Text;
        }

        public static void SendKeysToField(By element, string text)
        {
            Driver.FindElement(element).SendKeys(text);
        }

        public static void DeleteDefaulAndSendKeysToField(By element, string text)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Driver.FindElement(element)).DoubleClick().Click().SendKeys(Keys.Backspace).SendKeys(text).SendKeys(Keys.Tab).Build().Perform();
        }

        public string[] SplitDateString(By element)
        {
            return Driver.FindElement(element).Text.Split(' ');
        }

        public static string GetURL()
        {
            return Driver.Url;
        }

        public void SelectFromDropDown()
        {
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.Down).SendKeys(Keys.Down).SendKeys(Keys.Enter).Build().Perform();
        }

        public void SelectFromDynamicDropDown(string text)
        {
            Actions actions = new Actions(Driver);
            actions.SendKeys(text).Build().Perform();
            Thread.Sleep(5000);
            actions.SendKeys(Keys.Down).SendKeys(Keys.Down).SendKeys(Keys.Enter).Build().Perform();
        }

        public void ShortWait(By element)
        {
            wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }

        public void LongWait(By element)
        {
            wait = wait.LongerWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }

        public static By GetByXPathUsingLabel(string label)
        {
            return By.XPath($"//label[text()='{label}']/parent::div/following-sibling::div/input");
        }

        public static By GetByXPathElementBySpanText(string spanText)
        {
            return By.XPath($"//span[text()='{spanText}']");
        }

        public static By GetByXPathElementByInputName(string name)
        {
            return By.XPath($"//input[@name='{name}']");
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
