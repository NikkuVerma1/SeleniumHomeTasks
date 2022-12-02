using SeleniumHT2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeTests c = new ChromeTests();
            c.Setup();
            c.Elements();
            //c.Forms();
            //c.Alerts();
            //c.Widgets();
            //c.Interactions();
            //c.BookStore();
            //c.Register();
            //c.Login();
            c.EndTest();

            //FirefoxTests f = new FirefoxTests();
            //f.Setup();
            //f.Elements();
            //f.Forms();
            //f.Alerts();
            //f.Widgets();
            //f.Interactions();
            //f.BookStore();
            //f.Register();
            //f.Login();
            //f.EndTest();

            //EdgeTests e = new EdgeTests();
            //e.Setup();
            //e.Elements();
            //e.Forms();
            //e.Alerts();
            //e.Widgets();
            //e.Interactions();
            //e.BookStore();
            //e.Register();
            //e.Login();
            //e.EndTest();

            Console.ReadLine();
        }
    }
}
