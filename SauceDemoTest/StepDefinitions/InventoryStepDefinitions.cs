using AventStack.ExtentReports.Configuration;
using CommonFramework.Utility;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SauceDemoTest.StepDefinitions
{
    [Binding]
    public sealed class InventoryStepDefinitions:InventoryPage
    {
        [Given(@"I logged into application successfully")]
        public void GivenILoggedIntoApplicationSuccessfully()
        {
            Console.WriteLine("Logged in to application successfully!");
        }

        [Given(@"I navigated to inventory page")]
        public void GivenINavigatedToInventoryPage()
        {
            Console.WriteLine(GetURL());
            GetItemNameAndItemPrice();
        }

        [When(@"I click on '([^']*)' button for item")]
        public void WhenIClickOnButtonForItem(string addToCart)
        {
            AddItemsToCart();
        }

        [Then(@"the item should be added to the cart")]
        public void ThenTheItemShouldBeAddedToTheCart()
        {
            foreach (var item in InventoryPageItems)/////
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}