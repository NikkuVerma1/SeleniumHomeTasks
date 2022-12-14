using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest
{
    public class InventoryTest:BaseTest
    {
        [Test, Order(2)]
        public void InventoryPageTest()
        {
            LoginTest loginTest = new LoginTest();
            loginTest.LoginPageTest();
            InventoryPage inventoryPageTest = new InventoryPage();
            inventoryPageTest.GetItemNameAndItemPrice();
            inventoryPageTest.AddItemsToCart();
        }
    }
}
