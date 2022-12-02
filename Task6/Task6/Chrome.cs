using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task6
{
    public class ChromeTests:Tests
    {
        [SetUp]
        public override void Setup()
        {
             driver=new ChromeDriver();
             
        }

        
    }
}