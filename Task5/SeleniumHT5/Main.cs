using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace SeleniumHT5
{
    public class Main
    {
        public IWebDriver driver;

        [SetUp]
        public virtual void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LoginPopup()
        {
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[contains(text(),'✕')]")).Click();
        }

        [Test]
        public void TabsAvailableOrNot()
        {
            LoginPopup();
            IWebElement grocery = driver.FindElement(By.XPath("//div[contains(text(),'Grocery')]"));
            bool isGroceryDisplayed = grocery.Displayed;
            Assert.IsTrue(isGroceryDisplayed, "Grocery tab is available");

            IWebElement mobiles = driver.FindElement(By.XPath("//div[contains(text(),'Mobiles')]"));
            bool isMobilesDisplayed = mobiles.Displayed;
            Assert.IsTrue(isMobilesDisplayed, "Mobiles tab is available");

            IWebElement fashion = driver.FindElement(By.XPath("//div[contains(text(),'Fashion')]"));
            bool isFashionDisplayed = fashion.Displayed;
            Assert.IsTrue(isFashionDisplayed, "Fashion tab is available");

            IWebElement electronics = driver.FindElement(By.XPath("//div[contains(text(),'Electronics')]"));
            bool isElectronicsDisplayed = electronics.Displayed;
            Assert.IsTrue(isElectronicsDisplayed, "Electronics tab is available");

            IWebElement home = driver.FindElement(By.XPath("//div[@class='xtXmba' and text()='Home']"));
            bool isHomeDisplayed = home.Displayed;
            Assert.IsTrue(isHomeDisplayed, "Home tab is available");

            IWebElement appliances = driver.FindElement(By.XPath("//div[@class='xtXmba' and text()='Appliances']"));
            bool isAppliancesDisplayed = appliances.Displayed;
            Assert.IsTrue(isAppliancesDisplayed, "Appliances tab is available");

            IWebElement travel = driver.FindElement(By.XPath("//div[contains(text(),'Travel')]"));
            bool isTravelDisplayed = travel.Displayed;
            Assert.IsTrue(isTravelDisplayed, "Travel tab is available");

            IWebElement beautyToysAndMore = driver.FindElement(By.XPath("//div[@class='xtXmba' and text()='Beauty, Toys & More']"));
            bool isBeautyToysAndMoreDisplayed = beautyToysAndMore.Displayed;
            Assert.IsTrue(isBeautyToysAndMoreDisplayed, "Beauty, Toys & More tab is available");

        }

        [Test]
        public void SplitACResultsAndPrice()
        {
            LoginPopup();
            Actions action = new Actions(driver);
            IWebElement electronics = driver.FindElement(By.XPath("//div[contains(text(),'Electronics')]"));
            action.MoveToElement(electronics).Build().Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Cameras & Accessories")));

            driver.FindElement(By.LinkText("Cameras & Accessories")).Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]")));
            IWebElement app = driver.FindElement(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]"));
            action.MoveToElement(app).Build().Perform();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Split ACs")));
            IWebElement splictAC = driver.FindElement(By.LinkText("Split ACs"));
            action.MoveToElement(splictAC).Click().Build().Perform();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[contains(text(),'Showing 1 – 24')]")));
            bool isSplitAcResultCountDisplayed = driver.FindElement(By.XPath("//*[contains(text(),'Showing 1 – 24')]")).Displayed; //PageSource.Contains("Showing 1 – 24");

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@class='_1fQZEK']")));
            ReadOnlyCollection<IWebElement> splitACResults = driver.FindElements(By.XPath("//*[@class='_1fQZEK']"));
            bool isSplitACResultDisplayed = splitACResults.First().Displayed;
            bool isResultDisplayed = isSplitAcResultCountDisplayed & isSplitACResultDisplayed;

            Assert.IsTrue(isSplitAcResultCountDisplayed, "Split AC result count displayed");

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@class='_30jeq3 _1_WHN1']")));
            string priceBefore = driver.FindElements(By.XPath("//*[@class='_30jeq3 _1_WHN1']")).First().Text;
            driver.FindElements(By.XPath("//*[@class='_30jeq3 _1_WHN1']")).First().Click();
            string parentWindowHandle = driver.CurrentWindowHandle;
            List<string> windowHandles = driver.WindowHandles.ToList();
            string priceAfter = "";

            foreach (string windowHandle in windowHandles)
            {
                driver.SwitchTo().Window(windowHandle);
                if (!parentWindowHandle.Equals(windowHandle))
                {
                    priceAfter = driver.FindElement(By.XPath("//*[@class='_30jeq3 _16Jk6d']")).Text;
                    driver.Close();
                }
            }
            driver.SwitchTo().Window(parentWindowHandle);
            Assert.That(priceAfter, Is.EqualTo(priceBefore));
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}