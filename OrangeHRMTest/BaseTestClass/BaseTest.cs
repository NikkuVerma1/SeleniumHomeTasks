using CommonFramework.Base;
using CommonFramework.Reports;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OrangeHRMTest.TestData;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace OrangeHRMTest.BaseTestClass
{
    public class BaseTest : BaseSetup
    {
        public static ConfigSetting config;
        protected static string configSettingPath = System.IO.Directory.GetParent(GetAppConfigValue("fileParentPath")).FullName + 
            Path.DirectorySeparatorChar + GetAppConfigValue("configJsonPath");
        
        [SetUp]
        public void StartTest()
        {
            InvokeBrowser();
            config = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingPath).Build().Bind(config);
        }

        [TearDown]
        public void EndTest()
        {
            CloseBrowser();
        }
    }
}
