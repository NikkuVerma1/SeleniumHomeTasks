using SeleniumTask7;

namespace Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChromeTests c = new ChromeTests();
            c.Start();
            c.SearchResult();
            c.EndTest();

            //FirefoxTests f=new FirefoxTests();
            //f.Start();
            //f.SearchResult();
            //f.EndTest();
        }
    }
}