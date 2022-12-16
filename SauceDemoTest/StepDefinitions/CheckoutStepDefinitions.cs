using AventStack.ExtentReports.Configuration;
using CommonFramework.Utility;
using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SauceDemoTest.StepDefinitions
{
    [Binding]
    public sealed class CheckoutStepDefinitions:CheckoutPage
    {
        CartPage cartPage=new CartPage();

        [Given(@"I log in to application successfully")]
        public void GivenILogInToApplicationSuccessfully()
        {
            Console.WriteLine("Logged in to application successfully!");
        }

        [Given(@"I navigate to cart page")]
        public void GivenINavigateToCartPage()
        {
            Console.WriteLine(GetURL());
        }

        [When(@"I click on checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            cartPage.GoToCheckoutPage();
        }

        [When(@"I enter '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenIEnterAnd(string firstName, string lastName, string postalCode)
        {
            EnterCheckoutDetails(firstName, lastName, postalCode);
        }

        [When(@"I click continue button")]
        public void WhenIClickContinueButton()
        {
            Console.WriteLine("Checkout details are submitted");
        }

        [Then(@"I should see names and prices of items for checkout")]
        public void ThenIShouldSeeNamesAndPricesOfItemsForCheckout()
        {
            GetItemNameAndItemPrice();
            foreach (var item in CheckoutPageItems)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        [When(@"I click finish button to complete the checkout process")]
        public void WhenIClickFinishButtonToCompleteTheCheckoutProcess()
        {
            FinishCheckoutProcess();
        }

        [Then(@"checkout process should be completed successfully")]
        public void ThenCheckoutProcessShouldBeCompletedSuccessfully()
        {
            Console.WriteLine(GetURL());
        }

        //////////////////////////////////////////////////////////////////////////

        [When(@"I skip entering one of either '([^']*)', '([^']*)' or '([^']*)'")]
        public void WhenISkipEnteringOneOfEitherOr(string username, string password, string postalCode)
        {
            EnterCheckoutDetails(username, password, postalCode);
        }


        [Then(@"I should see error message")]
        public void ThenIShouldSeeErrorMessage()
        {
            DisplayErrorMessage();
            Console.WriteLine("Cannot proceed further!");
        }
    }
}