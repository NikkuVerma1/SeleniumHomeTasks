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
    public sealed class InventoryStepDefinitions:BaseTest//InventoryPage
    {
        InventoryPage inventoryPage=new InventoryPage();    
        [Given(@"I logged into application successfully")]
        public void GivenILoggedIntoApplicationSuccessfully()
        {
            LoginPage loginPage = new LoginPage();//////
            loginPage.LaunchApplication(config.ApplicationURL);//////
            loginPage.EnterCredentials(config.Username, config.Password);//////
            loginPage.ClickOnLoginButton();/////
            Console.WriteLine("Logged in to application successfully!");
        }

        [Given(@"I navigated to inventory page")]
        public void GivenINavigatedToInventoryPage()
        {
            Console.WriteLine(UIUtility.GetURL());
        }

        [When(@"I click on '([^']*)' button for item")]
        public void WhenIClickOnButtonForItem(string addToCart)
        {
            inventoryPage.AddItemsToCart();
        }

        [Then(@"the item should be added to the cart")]
        public void ThenTheItemShouldBeAddedToTheCart()
        {
            inventoryPage.GetItemNameAndItemPrice();
            foreach (var item in InventoryPage.InventoryPageItems)/////
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }

    }
}