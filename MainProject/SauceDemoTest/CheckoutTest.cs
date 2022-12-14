using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest
{
    public class CheckoutTest:BaseTest
    {
        [Test,Order(4)]
        public void CheckoutPageTest()
        {
            CartTest cartTest = new CartTest();
            cartTest.CartPageTest();
            CartPage cartPage = new CartPage();
            cartPage.GoToCheckoutPage();
            CheckoutPage checkoutPage = new CheckoutPage();
            checkoutPage.EnterCheckoutDetails(config.FirstName, config.LastName, config.PostalCode);
            checkoutPage.GetItemNameAndItemPrice();
            checkoutPage.FinishCheckoutProcess();
        }
    }
}
