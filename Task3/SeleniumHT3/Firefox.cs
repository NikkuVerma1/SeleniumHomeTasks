using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHT3
{
    public class Firefox : Browser
    {
        public override void Setup()
        {
            driver = new FirefoxDriver();
        }
    }
}
