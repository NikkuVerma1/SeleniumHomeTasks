using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumTask7
{
    public class Methods : Elements
    {
        public IWebDriver driver;

        [SetUp]
        public virtual void Start()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void SearchResult()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/");
            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//button[@class='header-search__button header__icon']")));
            searchButton = driver.FindElement(By.XPath("//button[@class='header-search__button header__icon']"));
            searchButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//li[@class='frequent-searches__item']")));
            value = driver.FindElements(By.XPath("//li[@class='frequent-searches__item']")).ElementAt(2);
            searchedValue = value.Text;
            value.Click();

            findButton = driver.FindElement(By.XPath("//button[contains(text(),'Find')]"));
            findButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//h2[@class='search-results__counter']")));
            searchResult = driver.FindElement(By.XPath("//h2[@class='search-results__counter']"));
            resultCount = searchResult.Text.Split(' ');
            if (Int32.Parse(resultCount[0]) > 10)
            {
                Console.WriteLine("More than 10 results were found");
            }

            resultDescription = driver.FindElements(By.XPath("//p[@class='search-results__description']"));
            foreach (var desc in resultDescription)
            {
                Assert.That(desc.Text.Contains(searchedValue));
            }

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
