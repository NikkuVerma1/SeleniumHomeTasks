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
using LibraryProject.Pages;
using TestProject.Test.BaseTestClass;

namespace TestProject.Test
{
    public class ResultTest:BaseTest
    {
        [Test]
        public void EpamSearchResultTest()
        {

            ResultPage resultPage = new ResultPage();
            SearchTest searchTest = new SearchTest();
            searchTest.EpamSearchTest();
            resultPage.Result();
            foreach(var element in ResultPage.resultDescriptionWebElements)
            {
                Assert.That(element.Text.Contains(config.SearchItem));
            }
        }
        
    }
}
