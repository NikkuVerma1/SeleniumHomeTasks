﻿using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Reports;
using AutomationFramework.Screenshots;
using TestProject.Test.BaseTestClass;
using LibraryProject.Exceptions;

namespace AutomationFramework.Test
{
    public class SearchTest:BaseTest
    {
        [Test]
        public void GoogleSearchTest()
        {
            SearchPage searchPage = new SearchPage();            
            er.test = er.report.CreateTest("SearchTest").Info("Test Started");
            NavigateToURL("https://www.google.com");
            //driver.Navigate().GoToUrl("https://www.google.com/");
            er.test.Log(Status.Info, "Google.com is launched");

            searchPage.TypeInTextInSearchBar("Christmas");
            er.test.Log(Status.Info, "Text is entered into search bar");

            searchPage.ClickOnSearchButton();
            er.test.Log(Status.Info, "Search button is clicked to display results");

            ////searchPage.Gift();

            ScreenShot.TakeScreenShot();
            er.test.Log(Status.Info, "Screenshot is taken for reference");
            if (er.test.Status == Status.Pass)
                er.test.Log(Status.Pass, "SearchTest Passed");
            else
                er.test.Log(Status.Fail, "SearchTest Failes");
            
        }
        
    }
}
