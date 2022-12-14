using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Pages;
using TestProject.Test.BaseTestClass;

namespace TestProject.Test
{
    public class SearchTest:BaseTest
    {
        [Test]
        public void EpamSearchTest()
        {
            SearchPage searchPage = new SearchPage();            
            NavigateToURL(config.ApplicationURL);
            searchPage.Search(config.SearchItem);            
        }
        
    }
}
