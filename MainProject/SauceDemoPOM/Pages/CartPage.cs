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
        //string xpath = "//div[@class='inventory_item_";
        //By itemPrice => By.XPath(xpath+"price']");
        //By itemName => By.XPath(xpath+"name']");
        By itemPrice => By.XPath("//div[@class='inventory_item_price']");
        By itemName => By.XPath("//div[@class='inventory_item_name']");
        By checkoutButton = By.XPath("//button[@id='checkout']");
        public static Dictionary<string, string> CartPageItems;
        #endregion

        #region Actions
        public void GetItemNameAndItemPrice()
        {
            CartPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.test.Log(Status.Info, "Item name and price are shown in cart page");
            Screenshots.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "CartTest Passed");
            else
                extentReport.test.Log(Status.Fail, "CartTest Failed");
        }
        public void GoToCheckoutPage()
        {
            ClickOnElement(checkoutButton);
            extentReport.test = extentReport.report.CreateTest("CheckoutTest").Info("Test Started");
            extentReport.test.Log(Status.Info, "Navigated to checkout page");
        }
        #endregion

    }
}
