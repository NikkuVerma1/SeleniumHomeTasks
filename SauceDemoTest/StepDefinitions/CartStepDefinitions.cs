using AventStack.ExtentReports.Configuration;
using CommonFramework.Utility;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo1.StepDefinitions
{
    [Binding]
    public sealed class CartStepDefinitions:CartPage
    {
        InventoryPage inventoryPage=new InventoryPage();

        [Given(@"I logged in to application successfully")]
        public void GivenILoggedInToApplicationSuccessfully()
        {
            Console.WriteLine("Logged in to application successfully!");
        }

        [When(@"I navigate to cart page")]
        public void WhenINavigateToCartPage()
        {
            inventoryPage.GoToCartPage();
            Console.WriteLine(GetURL());
        }

        [Then(@"I should see names and prices of items added to the cart")]
        public void ThenIShouldSeeNamesAndPricesOfItemsAddedToTheCart()
        {
            GetItemNameAndItemPrice();
            foreach (var item in CartPageItems)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}