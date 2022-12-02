using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Task5
{
    public class FirefoxTests:Tests
    {

        [SetUp]
        public override void Setup()
        {
            driver = new ChromeDriver();
            
        }
    }
}