using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace Task6
{
    public class EdgeTests:Tests
    {
        [SetUp]
        public override void Setup()
        {
             driver=new EdgeDriver();
             
        }

        
    }
}