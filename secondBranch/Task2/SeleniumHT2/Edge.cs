using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace SeleniumHT2
{
    public class EdgeTests
    {
        IWebDriver driver;
        IJavaScriptExecutor executor;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            executor = (IJavaScriptExecutor)driver;
        }

        [Test]
        public void Elements()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement elements = driver.FindElement(By.XPath("//h5[contains(text(),'Elements')]"));
            executor.ExecuteScript("arguments[0].click();", elements);
            IWebElement textBox = driver.FindElement(By.XPath("//span[contains(text(),'Text Box')]"));
            textBox.Click();
            IWebElement fullName = driver.FindElement(By.XPath("//input[@id='userName']"));
            fullName.SendKeys("Nikku Verma");
            IWebElement email = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            email.SendKeys("nikkuv@gmail.com");
            IWebElement currAdd = driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
            currAdd.SendKeys("B 22, Pahariya, Varanasi");
            IWebElement permAdd = driver.FindElement(By.XPath("//textarea[@id='permanentAddress']"));
            permAdd.SendKeys("B 22, Pahariya, Varanasi");
            IWebElement submit = driver.FindElement(By.XPath("//button[@id='submit']"));
            IJavaScriptExecutor submitExecutor = (IJavaScriptExecutor)driver;
            submitExecutor.ExecuteScript("arguments[0].click();", submit);
            IWebElement checkbox = driver.FindElement(By.XPath("//span[contains(text(),'Check Box')]"));
            checkbox.Click();
            IWebElement home = driver.FindElement(By.XPath("//span[contains(text(),'Home')]"));
            home.Click();
        }

        [Test]
        public void Forms()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            Actions a = new Actions(driver);

            IWebElement forms = driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]"));
            executor.ExecuteScript("arguments[0].click();", forms);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement practiceForm = driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));
            executor.ExecuteScript("arguments[0].click();", practiceForm);
            IWebElement firstName = driver.FindElement(By.XPath("//input[@id='firstName']"));
            firstName.SendKeys("Nikku");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@id='lastName']"));
            lastName.SendKeys("Verma");
            IWebElement email = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            email.SendKeys("nikkuv@gmail.com");
            IWebElement gender = driver.FindElement(By.XPath("//label[contains(text(),'Female')]"));
            executor.ExecuteScript("arguments[0].click();", gender);
            IWebElement mobile = driver.FindElement(By.XPath("//input[@id='userNumber']"));
            mobile.SendKeys("2226667890");
            IWebElement dob = driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            executor.ExecuteScript("arguments[0].click();", dob);
            SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']")));
            month.SelectByIndex(8);
            SelectElement year = new SelectElement(driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")));
            year.SelectByValue("1999");
            IWebElement date = driver.FindElement(By.XPath("//div[contains(text(),'15')]"));
            date.Click();

            executor.ExecuteScript("window.scrollBy(0,250)", "");
            a.Click(driver.FindElement(By.XPath("//div[contains(@class,'subjects-auto-complete__value-container')]"))).SendKeys("Maths" + Keys.Enter).Build().Perform();

            IWebElement sportshobby = driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
            executor.ExecuteScript("arguments[0].click();", sportshobby);
            IWebElement readinghobby = driver.FindElement(By.XPath("//label[contains(text(),'Reading')]"));
            executor.ExecuteScript("arguments[0].click();", readinghobby);
            IWebElement musichobby = driver.FindElement(By.XPath("//label[contains(text(),'Music')]"));
            executor.ExecuteScript("arguments[0].click();", musichobby);
            IWebElement uploadPicture = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture.SendKeys("C:\\Users\\Nikku_Verma1\\Downloads\\EPAM-Teams Background Image.jpg");
            IWebElement currAdd = driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
            currAdd.SendKeys("B 22, Pahariya, Varanasi");
            IWebElement state = driver.FindElement(By.XPath("//div[@class=' css-1wa3eu0-placeholder']"));
            executor.ExecuteScript("arguments[0].click();", state);
            executor.ExecuteScript("window.scrollBy(0,250);", "");

            executor.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[@id='submit']")));


        }

        [Test]
        public void Alerts()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement alerts = driver.FindElement(By.XPath("//h5[contains(text(),'Alerts, Frame & Windows')]"));
            executor.ExecuteScript("arguments[0].click();", alerts);
            IWebElement al = driver.FindElement(By.XPath("//span[text()='Alerts']"));
            IJavaScriptExecutor alExecutor = (IJavaScriptExecutor)driver;
            alExecutor.ExecuteScript("arguments[0].click();", al);

            IWebElement alertButton1 = driver.FindElement(By.XPath("//button[@id='alertButton']"));
            alertButton1.Click();
            driver.SwitchTo().Alert().Accept();


            IWebElement alertButton3 = driver.FindElement(By.XPath("//button[@id='confirmButton']"));
            alertButton3.Click();
            driver.SwitchTo().Alert().Accept();
            ////driver.SwitchTo().Alert().Dismiss();

            IWebElement alertButton4 = driver.FindElement(By.XPath("//button[@id='promtButton']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click();", alertButton4);
            driver.SwitchTo().Alert().SendKeys("Hello World!");
            driver.SwitchTo().Alert().Accept();

            //IWebElement alertButton2 = driver.FindElement(By.XPath("//button[@id='timerAlertButton']"));
            //alertButton2.Click();
            //driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void Widgets()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement widgets = driver.FindElement(By.XPath("//h5[contains(text(),'Widgets')]"));
            executor.ExecuteScript("arguments[0].click();", widgets);
            
        }

        [Test]
        public void Interactions()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement interactions = driver.FindElement(By.XPath("//h5[contains(text(),'Interactions')]"));
            executor.ExecuteScript("arguments[0].click();", interactions);
            
        }

        [Test]
        public void BookStore()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement bookStore = driver.FindElement(By.XPath("//h5[contains(text(),'Book Store Application')]"));
            executor.ExecuteScript("arguments[0].click();", bookStore);
            
        }

        [Test]
        public void Register()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            IWebElement newUser = driver.FindElement(By.Id("newUser"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", newUser);
            IWebElement firstName = driver.FindElement(By.Id("firstname"));
            firstName.SendKeys("Nikku");
            IWebElement lastName = driver.FindElement(By.Id("lastname"));
            lastName.SendKeys("Verma");
            IWebElement username = driver.FindElement(By.Id("userName"));
            username.SendKeys("nikku@gmail.com");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("abc123");
            IWebElement captcha = driver.FindElement(By.XPath("//div[@id='app']"));
            IJavaScriptExecutor captchaExecutor = (IJavaScriptExecutor)driver;
            captchaExecutor.ExecuteScript("arguments[0].click();", captcha);
            IWebElement register = driver.FindElement(By.Id("register"));
            IJavaScriptExecutor registerExecutor = (IJavaScriptExecutor)driver;
            registerExecutor.ExecuteScript("arguments[0].click();", register);
            
        }


        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            IWebElement username = driver.FindElement(By.Id("userName"));
            username.SendKeys("nikku@gmail.com");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("abc123");
            IWebElement login = driver.FindElement(By.Id("login"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", login);
            
        }


        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}