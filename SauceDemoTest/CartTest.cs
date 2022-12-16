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
        [Test]
        public void CartPageTest()
        {
            InventoryTest inventoryTest = new InventoryTest();
            InventoryPage inventoryPage = new InventoryPage();
            CartPage cartPage = new CartPage();
            inventoryTest.InventoryPageTest();
            inventoryPage.GoToCartPage();
            cartPage.GetItemNameAndItemPrice();
        }
    }
}
