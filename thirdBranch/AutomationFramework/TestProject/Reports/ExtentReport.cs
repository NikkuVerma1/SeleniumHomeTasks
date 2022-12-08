using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;

namespace AutomationFramework.Reports
{
    public class ExtentReport
    {
        public ExtentReports report = null;
        public ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\Nikku_Verma1\\source\\repos\\AutomationFramework\\TestProject\\Reports\\");
            report.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush(); 
        }
    }
}
