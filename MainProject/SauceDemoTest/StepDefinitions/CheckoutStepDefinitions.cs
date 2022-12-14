using AventStack.ExtentReports.Configuration;
using CommonFramework.Utility;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SauceDemoTest.StepDefinitions
{
    [Binding]
    public sealed class CheckoutStepDefinitions:BaseTest//CheckoutPage
    {
        InventoryPage inventoryPage = new InventoryPage();
        CartPage cartPage=new CartPage();
        CheckoutPage checkoutPage = new CheckoutPage();

        [Given(@"I log in to application successfully")]
        public void GivenILogInToApplicationSuccessfully()
        {
            LoginPage loginPage = new LoginPage();/////
            loginPage.LaunchApplication(config.ApplicationURL);//////
            loginPage.EnterCredentials(config.Username, config.Password);/////
            loginPage.ClickOnLoginButton();///////
            Console.WriteLine("Logged in to application successfully!");
        }

        [Given(@"I navigate to cart page")]
        public void GivenINavigateToCartPage()
        {
            InventoryPage inventoryPage = new InventoryPage();///
            inventoryPage.GetItemNameAndItemPrice();/////
            inventoryPage.AddItemsToCart();///////
            inventoryPage.GoToCartPage();///////
            cartPage.GetItemNameAndItemPrice();////////
            Console.WriteLine(UIUtility.GetURL());
        }

        [When(@"I click on checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            cartPage.GoToCheckoutPage();
        }

        [When(@"I enter '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenIEnterAnd(string firstName, string lastName, string postalCode)
        {
            checkoutPage.EnterCheckoutDetails(firstName, lastName, postalCode);
        }

        [When(@"I click continue button")]
        public void WhenIClickContinueButton()
        {
            Console.WriteLine("Checkout details are submitted");
        }

        [Then(@"I should see names and prices of items for checkout")]
        public void ThenIShouldSeeNamesAndPricesOfItemsForCheckout()
        {
            checkoutPage.GetItemNameAndItemPrice();
        }

        [When(@"I click finish button to complete the checkout process")]
        public void WhenIClickFinishButtonToCompleteTheCheckoutProcess()
        {
            checkoutPage.FinishCheckoutProcess();
        }

        [Then(@"checkout process should be completed successfully")]
        public void ThenCheckoutProcessShouldBeCompletedSuccessfully()
        {

        }


    }
}