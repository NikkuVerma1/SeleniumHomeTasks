using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Nikku_Verma1\\Downloads\\New Text Document.txt");
            Console.WriteLine("Enter text to write in the file:");
            string text1=Console.ReadLine();
            //while (text != string.Empty)
            //{
            //    text = Console.ReadLine();

            //}
            sw.WriteLine(text1);
            string text2=Console.ReadLine();
            sw.WriteLine(text2);
            string text3=Console.ReadLine();
            sw.WriteLine(text3);
            sw.Close();

            StreamReader sr=new StreamReader("C:\\Users\\Nikku_Verma1\\Downloads\\New Text Document.txt");
            string readText=sr.ReadToEnd();
            Console.WriteLine("Text read from the file: \n" + readText);

            string[] allLines=File.ReadAllLines("C:\\Users\\Nikku_Verma1\\Downloads\\New Text Document.txt");
            Console.WriteLine(allLines[0]);
            Console.WriteLine(allLines[1]);
            Console.WriteLine(allLines[2]);

            File.Copy("C:\\Users\\Nikku_Verma1\\Downloads\\New Text Document.txt", "C:\\Users\\Nikku_Verma1\\Downloads\\helloworld.txt");

            Console.ReadLine();
        }
    }
}
