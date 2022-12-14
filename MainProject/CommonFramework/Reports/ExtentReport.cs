using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFramework.Reports
{
    public class ExtentReport
    {
        public ExtentReports report = null;
        public ExtentTest test = null;
        //[OneTimeSetUp]
        public void ExtentStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["extentReportFilePath"]);
            report.AttachReporter(htmlReporter);
        }
        //[OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush();
        }
    }
}
