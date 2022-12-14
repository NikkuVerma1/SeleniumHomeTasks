using CommonFramework.Base;
using CommonFramework.Reports;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SauceDemoTest.TestData;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SauceDemoTest.BaseTestClass
{
    public class BaseTest : BaseClass
    {
        public static ConfigSetting config;
        protected static string configsettingpath = System.IO.Directory.GetParent(ConfigurationManager.AppSettings["fileParentPath"]).FullName + Path.DirectorySeparatorChar + ConfigurationManager.AppSettings["configJsonPath"];

        
        [SetUp]
        public void Setup()
        {
            Begin();
            //NavigateToURL(ConfigurationManager.AppSettings["applicationURL"]);
            //report.ExtentStart();
            config = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configsettingpath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
        }

        [TearDown]
        public void EndTest()
        {
            //report.ExtentClose();
            End();
        }
    }
}
