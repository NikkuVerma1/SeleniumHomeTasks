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
        By itemPrice => By.XPath("//div[@class='inventory_item_price']");
        By itemName => By.XPath("//div[@class='inventory_item_name']");
        By addToCartButton => By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");
        By cartButton => By.XPath("//a[@class='shopping_cart_link']");
        public static Dictionary<string, string> InventoryPageItems;
        #endregion

        #region Actions
        
        public void GetItemNameAndItemPrice()
        {
            InventoryPageItems = MakeDictionary(itemName, itemPrice);
            extentReport.test = extentReport.report.CreateTest("InventoryTest").Info("Test Started");
            extentReport.test.Log(Status.Info, "Item name and price are shown in inventory page");
        }
        public void AddItemsToCart()
        {           
            ClickOnElements(addToCartButton);
            extentReport.test.Log(Status.Info, "Items added to the cart");
            Screenshots.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "InventoryTest Passed");
            else
                extentReport.test.Log(Status.Fail, "InventoryTest Failed");
        }
        public void GoToCartPage()
        {
            ClickOnElement(cartButton);
            extentReport.test = extentReport.report.CreateTest("CartTest").Info("Test Started");
            extentReport.test.Log(Status.Info, "Navigated to cart page");
        }
        #endregion        
    }
}
