using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Reports;
using AutomationFramework.Screenshots;
using TestProject.Test.BaseTestClass;

namespace AutomationFramework.Test
{
    public class SignInTest:BaseTest
    {
        [Test]
        public void InvalidSignInTest()
        {
            
                SignInPage signInPage = new SignInPage();
                ExtentReport er = new ExtentReport();
                er.ExtentStart();
                er.test = er.report.CreateTest("SignInTest").Info("Test Started");
                NavigateToURl("https://www.google.com");
                //driver.Navigate().GoToUrl("https://www.google.com/");
                er.test.Log(Status.Info, "Google.com is launched");

                try { 
                signInPage.TypeInCredentials("nikku99", "abc123");
                }
                catch (TimeoutException e)
                {
                    Console.WriteLine("Timeout exception handled: " + e.Message);
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine("NoSuchElement exception handled: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception handled: " + e.Message);
                }
                //try {
                //driver.FindElement(By.Name("Passwd")).SendKeys("abc123");
                //}
                //catch (NoSuchElementException e)
                //{
                //Console.WriteLine("NoSuchElementException occurred: " + e.Message);
                //}

                er.test.Log(Status.Info, "Credentials are entered and submitted");

                ScreenShot.TakeScreenShot();
                er.test.Log(Status.Info, "Screenshot is taken for reference");
                if(er.test.Status==Status.Fail)
                er.test.Log(Status.Fail, "Invalid SignIn Test Failed");
                else
                er.test.Log(Status.Pass, "Invalid SignIn Test Passed");
                er.ExtentClose();
            
        }
        
    }
}
