using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.PageUtility;
using LibraryProject.ExtensionMethods;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework.Pages
{
    public class SearchPage:BasePage
    {
        By element;
        #region Locators
        private By searchBar => By.Name("q");
        private By searchButton => element.ByXPathOrByCSS("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']");
        public By signInButton => By.XPath("//a[contains(text(),'Sign in')]");
        #endregion


        #region Actions
        //public SearchPage(IWebDriver driver)
        //{
        //    this.driver=driver;
        //}       
        
        public void TypeInTextInSearchBar(string searchText)
        {
            //driver.FindElement(searchBar).SendKeys(searchText);
            SendKeysToField(searchBar, searchText);
        }
        public void ClickOnSearchButton()
        {
            //executor.ExecuteScript("arguments[0].click()", driver.FindElement(searchButton));
            ClickOnElementUsingJS(searchButton);
        }
        ////public void Gift()
        ////{
        ////    wait = wait.ShorterWait();
        ////    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//img[@jsname='fpF2df']")));
        ////    driver.FindElement(By.XPath("//img[@jsname='fpF2df']")).Click();

        ////}
        #endregion

    }
}
