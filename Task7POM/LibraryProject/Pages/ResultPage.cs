using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryProject;
using LibraryProject.Utilities.PageUtility;
using LibraryProject.ExtensionMethods;
using SeleniumExtras.WaitHelpers;

namespace LibraryProject.Pages
{
    public class ResultPage:BaseClass
    {
        By element;
        #region Locators
        private By searchResult => By.XPath("//h2[@class='search-results__counter']");
        private By resultDescription => By.XPath("//p[@class='search-results__description']");
        string[] resultCount;
        public static IReadOnlyCollection<IWebElement> resultDescriptionWebElements;
        #endregion


        #region Actions
          
        public void Result()
        {
            wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(searchResult));
            resultCount = StringSplit(searchResult);
            if (Int32.Parse(resultCount[0]) > 10)
            {
                Console.WriteLine("More than 10 results were found");
            }
            resultDescriptionWebElements = GetWebElements(resultDescription);
        }
                
        #endregion

    }
}
