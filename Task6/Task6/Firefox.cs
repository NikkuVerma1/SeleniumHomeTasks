using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Task6
{
    public class FirefoxTests:Tests
    {
        [SetUp]
        public override void Setup()
        {
             driver=new FirefoxDriver();
             
        }

    }
}