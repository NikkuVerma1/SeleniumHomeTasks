using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.PageUtility;

namespace AutomationFramework.Pages
{
    public class SignInPage:BasePage
    {
        #region Locators
        By emailId => By.XPath("//input[@id='identifierId']");
        By nextButton => By.XPath("//span[contains(text(),'Next')]");
        By password => By.Name("Passwd");
        #endregion


        #region Actions
        //public SignInPage(IWebDriver driver)
        //{
        //    this.driver=driver;
        //}       
        
        public void TypeInCredentials(string username,string passwd)
        {
            
                SearchPage sp = new SearchPage();
                //driver.FindElement(sp.signInButton).Click();
                //driver.FindElement(emailId).SendKeys(username);
                //driver.FindElement(nextButton).Click();
                //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(password));
                //driver.FindElement(password).SendKeys(passwd);
                //driver.FindElement(nextButton).Click();
                ClickOnElement(sp.signInButton);
                SendKeysToField(emailId,username);
                ClickOnElement(nextButton);
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(password));
                SendKeysToField(password, passwd);
                ClickOnElement(nextButton);                                
        }
       
        #endregion

    }
}
