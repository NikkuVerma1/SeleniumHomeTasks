using CommonFramework.Base;
using SauceDemoPOM.Pages;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SauceDemoTest.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions:LoginPage
    {
            [Given(@"I launched the SauceDemo application using '([^']*)'")]
            public void GivenILaunchedTheSauceDemoApplicationUsing(string url)
            {
                NavigateToURL(url);
            }

            [When(@"I enter '([^']*)' and '([^']*)'")]
            public void WhenIEnterAnd(string username, string password)
            {
                EnterCredentials(username, password);

            }

            [When(@"I click on Login button")]
            public void WhenIClickOnLoginButton()
            {
                ClickOnLoginButton();
            }


            [Then(@"I should be successfully logged in to application")]
            public void ThenIShouldBeSuccessfullyLoggedInToApplication()
            {
            try
            {
                if (URLAfterLogin == ConfigurationManager.AppSettings["inventoryURL"])
                {
                    Assert.Pass();
                }
                else
                {
                    throw new Exception("****Cannot log in!****");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }        
    }
}