using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Pages;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using TestProject.TestData;
using LibraryProject;

namespace TestProject.Test.BaseTestClass 
{
    public class BaseTest:BaseClass
    {
        protected static ConfigSetting config;
        protected static string configsettingpath = System.IO.Directory.GetParent(ConfigurationManager.AppSettings["configJsonParentPath"]).FullName + Path.DirectorySeparatorChar + ConfigurationManager.AppSettings["configJsonPath"];

        [SetUp]
        public void Setup()
        {
            Begin();
            config = new ConfigSetting();
            ConfigurationBuilder builder=new ConfigurationBuilder();
            builder.AddJsonFile(configsettingpath);
            IConfigurationRoot configuration=builder.Build();
            configuration.Bind(config);
        }

        [TearDown]
        public void EndTest()
        {
            End();
        }
    }
}
