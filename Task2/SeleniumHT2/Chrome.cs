using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;

namespace SeleniumHT2
{
    public class ChromeTests
    {
        IWebDriver driver;
        IJavaScriptExecutor executor;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
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
            executor.ExecuteScript("arguments[0].click();", submit);
            
            IWebElement checkbox = driver.FindElement(By.XPath("//span[contains(text(),'Check Box')]"));
            checkbox.Click();
            IWebElement home = driver.FindElement(By.XPath("//span[contains(text(),'Home')]"));
            home.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Radio Button']")));
            IWebElement radio = driver.FindElement(By.XPath("//span[text()='Radio Button']"));
            executor.ExecuteScript("arguments[0].click();",radio);
            IWebElement yes = driver.FindElement(By.XPath("//label[contains(text(),'Yes')]"));
            yes.Click();
            IWebElement impressive = driver.FindElement(By.XPath("//label[contains(text(),'Impressive')]"));
            impressive.Click();

            Actions a = new Actions(driver);
            IWebElement buttons = driver.FindElement(By.XPath("//span[contains(text(),'Buttons')]"));
            executor.ExecuteScript("arguments[0].click();", buttons);
            IWebElement doubleClickButton = driver.FindElement(By.XPath("//button[@id='doubleClickBtn']"));
            a.DoubleClick(doubleClickButton);
            IWebElement rightClickButton = driver.FindElement(By.XPath("//button[@id='rightClickBtn']"));
            a.ContextClick(rightClickButton);
            IWebElement clickButton = driver.FindElement(By.XPath("//button[text()='Click Me']"));
            clickButton.Click();
        }

        [Test]
        public void Forms()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
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
            gender.Click();
            IWebElement mobile = driver.FindElement(By.XPath("//input[@id='userNumber']"));
            mobile.SendKeys("2226667890");
            IWebElement dob = driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            executor.ExecuteScript("arguments[0].click();",dob);
            SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']")));
            month.SelectByIndex(8);
            /////////
            SelectElement year = new SelectElement(driver.FindElement(By.XPath("react-datepicker__year-select")));
            year.SelectByValue("1999");
            IWebElement date = driver.FindElement(By.XPath("//div[contains(text(),'15')]"));
            date.Click();
            IWebElement sportshobby = driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
            executor.ExecuteScript("arguments[0].click();", sportshobby);
            IWebElement readinghobby = driver.FindElement(By.XPath("//label[contains(text(),'Reading')]"));
            executor.ExecuteScript("arguments[0].click();", readinghobby); 
            IWebElement musichobby = driver.FindElement(By.XPath("//label[contains(text(),'Music')]"));
            executor.ExecuteScript("arguments[0].click();", musichobby); 
            IWebElement currAdd = driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
            currAdd.SendKeys("B 22, Pahariya, Varanasi");
            IWebElement state = driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]"));
            executor.ExecuteScript("arguments[0].click();",state);
            executor.ExecuteScript("window.scrollBy(0,250);", "");
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[contains(text(),'Uttar Pradesh')]")));
            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(By.XPath("//div[contains(text(),'Uttar Pradesh')]"))).Click().Build().Perform();
            
            driver.FindElement(By.XPath("//button[@id='submit']")).Click();
        }

        [Test]
        public void Alerts()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement alerts = driver.FindElement(By.XPath("//h5[contains(text(),'Alerts, Frame & Windows')]"));
            executor.ExecuteScript("arguments[0].click();", alerts);

            IWebElement al = driver.FindElement(By.XPath("//span[text()='Alerts']"));
            IJavaScriptExecutor alExecutor = (IJavaScriptExecutor)driver;
            alExecutor.ExecuteScript("arguments[0].click();", al);

            IWebElement alertButton = driver.FindElement(By.XPath("//button[@id='alertButton']"));
            alertButton.Click();
            driver.SwitchTo().Alert().Accept();


            //IWebElement timerAlertButton = driver.FindElement(By.XPath("//button[@id='timerAlertButton']"));
            //timerAlertButton.Click();
            //Thread.Sleep(6000);
            //driver.SwitchTo().Alert().Accept();

            IWebElement confirmButton = driver.FindElement(By.XPath("//button[@id='confirmButton']"));
            alExecutor.ExecuteScript("arguments[0].click();",confirmButton);
            driver.SwitchTo().Alert().Accept();
            ////driver.SwitchTo().Alert().Dismiss();

            IWebElement promptButton = driver.FindElement(By.XPath("//button[@id='promtButton']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click();", promptButton);
            driver.SwitchTo().Alert().SendKeys("Hello World!");
            driver.SwitchTo().Alert().Accept();


            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent Window Handle: "+parentWindowHandle);
            IWebElement windows = driver.FindElement(By.XPath("//span[text()='Browser Windows']"));
            alExecutor.ExecuteScript("arguments[0].click();", windows);
            IWebElement newWindow = driver.FindElement(By.XPath("//button[@id='windowButton']"));
            newWindow.Click();
            IWebElement newWindowMessage = driver.FindElement(By.XPath("//button[@id='messageWindowButton']"));
            newWindowMessage.Click();
            List<string> windowHandles = driver.WindowHandles.ToList();
            foreach (string windowHandle in windowHandles)
            {
                driver.SwitchTo().Window(windowHandle);
                if (!parentWindowHandle.Equals(windowHandle))
                {
                    driver.Close();
                    Console.WriteLine("Child window ("+windowHandle+") closed");

                }
            }
            
            driver.SwitchTo().Window(parentWindowHandle);
            Console.WriteLine("Parent Window Title: "+driver.Title);


            IWebElement frames = driver.FindElement(By.XPath("//span[text()='Frames']"));
            alExecutor.ExecuteScript("arguments[0].click();", frames);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frame1")));
            //Console.WriteLine(driver.FindElement(By.XPath("//h1[@id='sampleHeading']")).Text);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frame1")));
           // Console.WriteLine(driver.FindElement(By.XPath("//h1[@id='sampleHeading']")).Text);
            driver.SwitchTo().DefaultContent();
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
            executor.ExecuteScript("window.scrollBy(0,350)", "");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/form[1]/div[6]/div[1]/div[1]/div[1]/iframe[1]")));
            IWebElement captcha = driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/form[1]/div[6]/div[1]/div[1]/div[1]/iframe[1]"));
            executor.ExecuteScript("arguments[0].click();", captcha);
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