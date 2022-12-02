using SeleniumHT5;

namespace Selenium5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Main c = new ChromeTests();
            c.Setup();
            //c.LoginPopup();
            //c.TabsAvailableOrNot();
            c.SplitACResultsAndPrice();
            c.EndTest();
        }
    }
}