using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHT6;

namespace SeleniumHT6
{
    public class ChromeTests : Main
    {
        [SetUp]
        public override void Setup()
        {
            driver = new ChromeDriver();

        }


    }
}