using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumHT1;
using System;
using System.Security.Claims;

namespace SeleniumHT1
{
    public class EdgeTests : GoogleSearch
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void SearchTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            //IWebElement searchBox = driver.FindElement(By.CssSelector("input[name$='q']"));
            searchBox.SendKeys("Mountains");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchButton = wait.Until(s => s.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']")));
            //IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']"));
            searchButton.Click();
            
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}

