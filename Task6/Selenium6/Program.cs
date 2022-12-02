using SeleniumHT6;

namespace Selenium6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeTests c=new ChromeTests();
            c.Setup();
            c.Login();
            c.AddToCart();
            c.Cart();
            c.Checkout();
            c.EndTest();

            //FirefoxTests f = new FirefoxTests();
            //f.Setup();
            //f.Login();
            //f.AddToCart();
            //f.Cart();
            //f.Checkout();
            //f.EndTest();

            //EdgeTests e = new EdgeTests();
            //e.Setup();
            //e.Login();
            //e.AddToCart();
            //e.Cart();
            //e.Checkout();
            //e.EndTest();
            Console.ReadLine();                                 
        }
    }
}