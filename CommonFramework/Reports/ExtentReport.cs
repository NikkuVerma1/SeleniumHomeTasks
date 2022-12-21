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
        public ExtentReports Report {get; set;} = new ExtentReports();
        public ExtentTest Test { get; set; } = null;
        public ExtentTest Node { get; set; }

        //[OneTimeSetUp]
        public void ExtentStart()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string project = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            string reportFilePath = project + ConfigurationManager.AppSettings["extentReportRelativeFilePath"];
            var htmlReporter = new ExtentHtmlReporter(reportFilePath);   
            Report.AttachReporter(htmlReporter);
        }

        //[OneTimeTearDown]
        public void ExtentClose()
        {
            Report.Flush();
        }
    }
}
