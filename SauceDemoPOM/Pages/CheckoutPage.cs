using OpenQA.Selenium;
using CommonFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using CommonFramework.Screenshots;

namespace SauceDemoPOM.Pages
{ 
    public class CheckoutPage:UIUtility
    {
        #region Locators
        string commonPartValueOfClassname => "inventory_item_";
        By firstNameField => GetByXPathElementById("first-name");
        By lastNameField => GetByXPathElementById("last-name");
        By postalCodeField => GetByXPathElementById("postal-code");
        By continueButton => GetByXPathElementById("continue");
        By itemPrice => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "price");
        By itemName => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "name");
        public static Dictionary<string, string> CheckoutPageItems;
        By finishButton => By.XPath("//button[@id='finish']");
        By errorMessage => By.TagName("h3");
        #endregion

        #region Actions
        public void EnterCheckoutDetails(string firstName, string lastName, string postalCode)
        {
            SendKeysToField(firstNameField, firstName);
            SendKeysToField(lastNameField, lastName);
            SendKeysToField(postalCodeField, postalCode);
            ClickOnElement(continueButton);
            extentReport.Test.Log(Status.Info, "Checkout details are entered and submitted");
        }

        public void GetItemNameAndItemPrice()
        {
            CheckoutPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.Test.Log(Status.Info, "Item name and price are shown in checkout page");
        }

        public void FinishCheckoutProcess()
        {
            ClickOnElement(finishButton);
            extentReport.Test.Log(Status.Info, "Checkout process completed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "CheckoutTest Passed", Screenshots.TakeScreenShot("CheckoutPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "CheckoutTest Failed", Screenshots.TakeScreenShot("CheckoutPageScreenshot.png"));
        }

        public void DisplayErrorMessage()
        {
            if (DisplayedOrNot(errorMessage))
            {
                extentReport.Test.Log(Status.Error, "Error message is displayed due to incomplete user details. Cannot proceed.", Screenshots.TakeScreenShot("CheckoutPageScreenshot.png"));                
            }
        }
        #endregion

    }
}
