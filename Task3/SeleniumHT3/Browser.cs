using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHT3
{
    public class Browser
    {
        public IWebDriver driver;
        public virtual void Setup()
        {

        }

        public void Test()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string title = driver.Title;
            int titleLength = driver.Title.Length;
            Console.WriteLine("Page Title: " + title + " \nTitle Length: " + titleLength);
            string url = driver.Url;
            int urlLength = driver.Url.Length;
            Console.WriteLine("Page URL: " + url + " \nPage URL Length: " + urlLength);
            //Console.WriteLine("Page Source Length: " + driver.PageSource.Length + "\nPage Source: " + driver.PageSource);
            string pageSource = driver.PageSource;
            int pageSourceLength = driver.PageSource.Length;
            Console.WriteLine("Page Source: " + pageSource);
            Console.WriteLine("Page Source Length: " + pageSourceLength);
        }

        public void EndTest()
        {
            driver.Close();
        }

    }
}
