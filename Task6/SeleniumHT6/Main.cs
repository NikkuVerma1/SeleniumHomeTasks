using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHT6
{
    public class Main
    {
        public IWebDriver driver;
        private string initialPrice = "";
        string itemName = "";
        By checkoutButton = By.XPath("//button[@id='checkout']");

        [SetUp]
        public virtual void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test, Order(1)]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            IWebElement userName = driver.FindElement(By.XPath("//input[@id='user-name']"));
            userName.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='password']"));
            password.SendKeys("secret_sauce");
            IWebElement login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            login.Click();
        }

        [Test, Order(2)]
        public void AddToCart()
        {
            Login();
            itemName = driver.FindElement(By.XPath("//div[contains(text(),'Sauce Labs Backpack')]")).Text;
            initialPrice = driver.FindElements(By.XPath("//div[@class='inventory_item_price']")).First().Text;
            IWebElement addToCartButton = driver.FindElements(By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']")).First();
            addToCartButton.Click();

        }

        [Test, Order(3)]
        public void Cart()
        {
            AddToCart();
            IWebElement cart = driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            cart.Click();
            string finalPrice = driver.FindElements(By.XPath("//div[@class='inventory_item_price']")).First().Text;
            Assert.That(finalPrice, Is.EqualTo(initialPrice));
        }

        [Test, Order(4)]
        public void Checkout()
        {
            Cart();
            IWebElement checkout = driver.FindElement(checkoutButton);
            checkout.Click();
            IWebElement firstName = driver.FindElement(By.XPath("//input[@id='first-name']"));
            firstName.SendKeys("Nikku");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@id='last-name']"));
            lastName.SendKeys("Verma");
            IWebElement postalCode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            postalCode.SendKeys("221007");
            IWebElement continueButton = driver.FindElement(By.XPath("//input[@id='continue']"));
            continueButton.Click();
            String finalItemName = driver.FindElement(By.XPath("//div[contains(text(),'Sauce Labs Backpack')]")).Text;
            Assert.That(finalItemName, Is.EqualTo(itemName));
            string finalItemPrice = driver.FindElement(By.XPath("//div[@class='inventory_item_price']")).Text;
            Assert.That(initialPrice, Is.EqualTo(finalItemPrice));
            IWebElement finishButton = driver.FindElement(By.XPath("//button[@id='finish']"));
            finishButton.Click();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}