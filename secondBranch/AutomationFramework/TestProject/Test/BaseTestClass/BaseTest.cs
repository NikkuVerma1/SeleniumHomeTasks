using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;

namespace TestProject.Test.BaseTestClass 
{
    public class BaseTest:BasePage
    {
        //BasePage basePage=new BasePage();

        [SetUp]
        public void Setup()
        {
            Begin();
        }

        [TearDown]
        public void EndTest()
        {
            End();
        }
    }
}
