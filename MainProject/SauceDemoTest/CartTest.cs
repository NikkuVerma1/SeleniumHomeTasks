using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest
{
    public class CartTest:BaseTest
    {
        [Test, Order(3)]
        public void CartPageTest()
        {
            InventoryTest inventoryTest = new InventoryTest();
            inventoryTest.InventoryPageTest();
            InventoryPage inventoryPage = new InventoryPage();
            inventoryPage.GoToCartPage();
            CartPage cartPage = new CartPage();
            cartPage.GetItemNameAndItemPrice();
            //Assert.IsTrue(InventoryPage.InventoryPageItems == CartPage.CartPageItems);
        }
    }
}
