using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumHT6
{
    public class FirefoxTests : Main
    {
        [SetUp]
        public override void Setup()
        {
            driver = new FirefoxDriver();

        }


    }
}