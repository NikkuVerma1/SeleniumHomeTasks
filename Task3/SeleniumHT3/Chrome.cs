using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHT3
{
     public class Chrome : Browser
    {
        public override void Setup()
        {
            driver = new ChromeDriver();
        }
    }
}
