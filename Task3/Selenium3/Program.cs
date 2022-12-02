using SeleniumHT3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chrome c = new Chrome();
            c.Setup();
            c.Test();
            c.EndTest();
            Firefox f = new Firefox();
            f.Setup();
            f.Test();
            f.EndTest();
            Edge e = new Edge();
            e.Setup();
            e.Test();
            e.EndTest();
            Console.ReadLine();
        }
    }
}
