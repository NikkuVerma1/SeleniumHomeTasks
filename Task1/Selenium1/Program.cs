using SeleniumHT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeTests c = new ChromeTests();
            c.Setup();
            c.SearchTest();
            c.EndTest();
            FirefoxTests f = new FirefoxTests();
            f.Setup();
            f.SearchTest();
            f.EndTest();
            EdgeTests e = new EdgeTests();
            e.Setup();
            e.SearchTest();
            e.EndTest();

            Console.ReadLine();

        }
    }
}
