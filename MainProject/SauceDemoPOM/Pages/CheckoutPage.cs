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
        By firstNameField => By.XPath("//input[@id='first-name']");
        By lastNameField => By.XPath("//input[@id='last-name']");
        By postalCodeField => By.XPath("//input[@id='postal-code']");
        By continueButton => By.XPath("//input[@id='continue']");
        By itemPrice => By.XPath("//div[@class='inventory_item_price']");
        By itemName => By.XPath("//div[@class='inventory_item_name']");
        public static Dictionary<string, string> CheckoutPageItems;
        By finishButton => By.XPath("//button[@id='finish']");

        #endregion
        #region Actions
        public void EnterCheckoutDetails(string firstName, string lastName, string postalCode)
        {
            SendKeysToField(firstNameField, firstName);
            SendKeysToField(lastNameField, lastName);
            SendKeysToField(postalCodeField, postalCode);
            ClickOnElement(continueButton);
            extentReport.test.Log(Status.Info, "Checkout details are entered and submitted");
        }
        public void GetItemNameAndItemPrice()
        {
            CheckoutPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.test.Log(Status.Info, "Item name and price are shown in checkout page");
        }
        public void FinishCheckoutProcess()
        {
            ClickOnElement(finishButton);
            extentReport.test.Log(Status.Info, "Checkout process completed");
            Screenshots.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "CheckoutTest Passed");
            else
                extentReport.test.Log(Status.Fail, "CheckoutTest Failed");
        }
        #endregion

    }
}
