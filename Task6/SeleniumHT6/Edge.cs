using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using SeleniumHT6;

namespace SeleniumHT6
{
    public class EdgeTests : Main
    {
        [SetUp]
        public override void Setup()
        {
            driver = new EdgeDriver();

        }


    }
}