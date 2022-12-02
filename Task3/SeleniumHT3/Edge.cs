using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHT3
{
    public class Edge : Browser
    {
        public override void Setup()
        {
            driver = new EdgeDriver();
        }
    }
}
