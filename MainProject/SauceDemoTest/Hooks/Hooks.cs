using CommonFramework.Base;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SauceDemoTest.Hooks
{
    [Binding]
    public sealed class Hooks:BaseTest
    {        
        [BeforeScenario]
        public void BeforeScenario()
        {
            Setup();
        }

        //[BeforeScenario("inventory")]
        //[BeforeScenario("cart")]
        //[BeforeScenario("checkout")]
        //public void LoginToApplication()
        //{
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.LaunchApplication(config.ApplicationURL);
        //    loginPage.EnterCredentials(config.Username, config.Password);
        //    loginPage.ClickOnLoginButton();
        //}

        //[BeforeScenario("cart")]
        //[BeforeScenario("checkout")]
        //public void AddItemsToCart()
        //{
        //    InventoryPage inventoryPage = new InventoryPage();
        //    inventoryPage.GetItemNameAndItemPrice();
        //    inventoryPage.AddItemsToCart();

        //}

        //[BeforeScenario("checkout")]
        //public void GoToCartPage()
        //{
        //    InventoryPage inventoryPage = new InventoryPage();
        //    inventoryPage.GoToCartPage();
        //    CartPage cartPage = new CartPage();
        //    cartPage.GetItemNameAndItemPrice();
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            EndTest();
        }
    }
}