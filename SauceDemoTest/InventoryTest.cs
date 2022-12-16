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
        [Test]
        public void InventoryPageTest()
        {
            LoginTest loginTest = new LoginTest();
            InventoryPage inventoryPageTest = new InventoryPage();
            loginTest.LoginPageTest();
            inventoryPageTest.GetItemNameAndItemPrice();
            inventoryPageTest.AddItemsToCart();
        }
    }
}
