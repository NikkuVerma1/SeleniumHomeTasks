using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Task5
{
    public class EdgeTests:Tests
    {

        [SetUp]
        public override void Setup()
        {
            driver = new ChromeDriver();
            
        }
    }
}