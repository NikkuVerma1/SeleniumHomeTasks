using AventStack.ExtentReports.Configuration;
using CommonFramework.Utility;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo1.StepDefinitions
{
    [Binding]
    public sealed class CartStepDefinitions:BaseTest//CartPage
    {
        InventoryPage inventoryPage=new InventoryPage();
        CartPage cartPage=new CartPage();

        [Given(@"I logged in to application successfully")]
        public void GivenILoggedInToApplicationSuccessfully()
        {
            LoginPage loginPage = new LoginPage();/////
            loginPage.LaunchApplication(config.ApplicationURL);//////
            loginPage.EnterCredentials(config.Username, config.Password);/////
            loginPage.ClickOnLoginButton();///////
            Console.WriteLine("Logged in to application successfully!");
        }

        [When(@"I navigate to cart page")]
        public void WhenINavigateToCartPage()
        {
            inventoryPage.GetItemNameAndItemPrice(); ////
            inventoryPage.AddItemsToCart();  /////
            inventoryPage.GoToCartPage();
            Console.WriteLine(UIUtility.GetURL());
        }

        [Then(@"I should see names and prices of items added to the cart")]
        public void ThenIShouldSeeNamesAndPricesOfItemsAddedToTheCart()
        {
            cartPage.GetItemNameAndItemPrice();
            foreach (var item in CartPage.CartPageItems)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }


    }
}