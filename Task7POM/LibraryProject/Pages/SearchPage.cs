using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Utilities.PageUtility;
using LibraryProject.ExtensionMethods;
using OpenQA.Selenium.Support.UI;

namespace LibraryProject.Pages
{
    public class SearchPage:BaseClass
    {
        By element;

        #region Locators
        By searchButton => element.ByXPathOrByCSS("//button[@class='header-search__button header__icon']");
        By searchItems => By.XPath("//li[@class='frequent-searches__item']");
        By findButton => By.XPath("//button[contains(text(),'Find')]");        
        #endregion


        #region Actions
             
        public void Search(string searchItem)
        {
            wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(searchButton));
            ClickOnElement(searchButton);
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(searchItems));
            ClickOnOneOfElements(searchItems, searchItem);
            ClickOnElement(findButton);
        }        
       
        #endregion

    }
}
