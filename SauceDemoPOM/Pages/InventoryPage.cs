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
    public class InventoryPage:UIUtility
    {
        #region Locators
        string commonPartValueOfClassname => "inventory_item_";
        By itemPrice => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "price");
        By itemName => GetByXPathElementForCommonPartOfClass(commonPartValueOfClassname, "name");
        By addToCartButton => By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");
        By cartButton => By.XPath("//a[@class='shopping_cart_link']");
        public static Dictionary<string, string> InventoryPageItems;
        #endregion

        #region Actions        
        public void GetItemNameAndItemPrice()
        {
            InventoryPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.Test = extentReport.Report.CreateTest("InventoryTest").Info("Test Started");
            extentReport.Test.Log(Status.Info, "Item name and price are shown in inventory page");
        }

        public void AddItemsToCart()
        {           
            ClickOnElements(addToCartButton);
            extentReport.Test.Log(Status.Info, "Items added to the cart");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "InventoryTest Passed", Screenshots.TakeScreenShot("InventoryPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "InventoryTest Failed", Screenshots.TakeScreenShot("InventoryPageScreenshot.png"));
        }

        public void GoToCartPage()
        {
            ClickOnElement(cartButton);
            extentReport.Test = extentReport.Report.CreateTest("CartTest").Info("Test Started");
            extentReport.Test.Log(Status.Info, "Navigated to cart page");
        }
        #endregion        
    }
}
