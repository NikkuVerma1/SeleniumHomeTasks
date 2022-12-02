using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumHT4;

namespace Selenium4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tests test = new Tests();
            test.Setup();
            test.TooShort();
            test.TooLong();
            test.EqualTo8();
            test.EqualTo12();
            test.JustLessThan8();
            test.JustLessThan12();
            test.JustGreaterThan8();
            test.JustGreaterThan12();
            test.NotAString();
            Console.ReadLine();
        }
    }
}
