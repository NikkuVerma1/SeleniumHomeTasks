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
        [Test]
        public void CheckoutPageTest()
        {
            CartTest cartTest = new CartTest();
            CartPage cartPage = new CartPage();
            CheckoutPage checkoutPage = new CheckoutPage();
            cartTest.CartPageTest();
            cartPage.GoToCheckoutPage();
            checkoutPage.EnterCheckoutDetails(config.FirstName, config.LastName, config.PostalCode);
            checkoutPage.GetItemNameAndItemPrice();
            checkoutPage.FinishCheckoutProcess();
        }
    }
}
