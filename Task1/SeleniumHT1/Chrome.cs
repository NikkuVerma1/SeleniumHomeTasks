using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Security.Claims;
using SeleniumHT1;
using NUnit.Framework;
using System;

namespace SeleniumHT1
{
    public class ChromeTests : GoogleSearch
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
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
            IWebElement searchButton = wait.Until(s=>s.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']")));
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















