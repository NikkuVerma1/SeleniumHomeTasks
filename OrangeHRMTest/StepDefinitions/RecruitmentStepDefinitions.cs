using CommonFramework.Base;
using CommonFramework.Utility;
using OrangeHRMPOM.Pages.Login;
using OrangeHRMPOM.Pages.Recruitment;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public sealed class RecruitmentStepDefinitions : Recruitment
    {
        [Given(@"I logged into OrangeHRM application successfully")]
        public void GivenILoggedIntoOrangeHRMApplicationSuccessfully()
        {
            Console.WriteLine("Logged in to application successfully!");
        }

        [Given(@"I clicked on recruitment tab")]
        public void GivenIClickedOnRecruitmentTab()
        {
            ClickOnRecruitmentTab();
        }

        [When(@"I click on add button")]
        public void WhenIClickOnAddButton()
        {
            ClickOnAddButton();
        }

        [Then(@"I should navigate to '([^']*)' page")]
        public void ThenIShouldNavigateToPage(string addCandidatePage)
        {
            Console.WriteLine(GetURL());
        }

        [When(@"I enter '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenIEnterAnd(string firstName, string lastName, string email)
        {
            AddCandidate.EnterCandidateDetails(firstName, lastName, email);
        }

        [When(@"I click save button")]
        public void WhenIClickSaveButton()
        {
            AddCandidate.ClickOnSubmitButton();
        }

        [Then(@"the candidate should be added")]
        public void ThenTheCandidateShouldBeAdded()
        {
            if (AddCandidate.IsPersonAdded())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }        

        [When(@"I enter '([^']*)', leave '([^']*)' as blank and enter '([^']*)'")]
        public void WhenIEnterLeaveAsBlankAndEnter(string firstName, string lastName, string email)
        {
            AddCandidate.EnterCandidateDetails(firstName, lastName, email);
        }

        [Then(@"the candidate should not be added and error message should be displayed")]
        public void ThenTheCandidateShouldNotBeAddedAndErrorMessageShouldBeDisplayed()
        {
            if (AddCandidate.IsErrorDisplayed())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}
