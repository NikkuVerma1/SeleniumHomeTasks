using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Reports;

namespace TestProject.Test.BaseTestClass 
{
    public class BaseTest:BasePage
    {
        //BasePage basePage=new BasePage();

        protected ExtentReport er = new ExtentReport();

        [SetUp]
        public void Setup()
        {
            Begin();
            er.ExtentStart();
        }

        [TearDown]
        public void EndTest()
        {
            er.ExtentClose();
            End();
        }
    }
}
