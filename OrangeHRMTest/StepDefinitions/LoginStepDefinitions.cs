using CommonFramework.Base;
using CommonFramework.Utility;
using OrangeHRMPOM.Pages.Login;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions : Login
    {
        [Given(@"I launched the OrangeHRM application using '([^']*)'")]
        public void GivenILaunchedTheOrangeHRMApplicationUsing(string url)
        {
            LaunchApplication(url);
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
                if (URLAfterLogin == ConfigurationManager.AppSettings["dashboardURL"])
                {
                    Assert.Pass();
                }
                else
                {
                    throw new Exception("****Cannot log in!****");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
