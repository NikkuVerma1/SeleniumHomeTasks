using CommonFramework.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AventStack.ExtentReports;
using CommonFramework.Screenshots;

namespace SauceDemoPOM.Pages
{
    public class CartPage:UIUtility
    {
        #region Locators
        string commonPartValueOfClassname => "inventory_item_";
        By itemPrice => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "price");
        By itemName => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "name");
        By checkoutButton => By.XPath("//button[@id='checkout']");
        public static Dictionary<string, string> CartPageItems;
        #endregion

        #region Actions
        public void GetItemNameAndItemPrice()
        {
            CartPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.Test.Log(Status.Info, "Item name and price are shown in cart page");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "CartTest Passed", Screenshots.TakeScreenShot("CartPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "CartTest Failed", Screenshots.TakeScreenShot("CartPageScreenshot.png"));
        }

        public void GoToCheckoutPage()
        {
            ClickOnElement(checkoutButton);
            extentReport.Test = extentReport.Report.CreateTest("CheckoutTest").Info("Test Started");
            extentReport.Test.Log(Status.Info, "Navigated to checkout page");
        }
        #endregion

    }
}
