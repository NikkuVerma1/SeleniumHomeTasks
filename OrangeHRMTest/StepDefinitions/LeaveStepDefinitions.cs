using CommonFramework.Base;
using CommonFramework.Utility;
using OrangeHRMPOM.Pages.Leave;
using OrangeHRMPOM.Pages.Login;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public sealed class LeaveStepDefinitions : Leave
    {
        [Given(@"I clicked on leave tab")]
        public void GivenIClickedOnLeaveTab()
        {
            ClickOnLeaveTab();  
        }

        [When(@"I get from and to dates of leave from record")]
        public void WhenIGetFromAndToDatesOfLeaveFromRecord()
        {
            GetFromAndToDates();
        }

        [When(@"I enter the dates in respective fields")]
        public void WhenIEnterTheDatesInRespectiveFields()
        {
            EnterFromAndToDates();
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            ClickOnSubmitButton();
        }

        [Then(@"related record should be displayed")]
        public void ThenRelatedRecordShouldBeDisplayed()
        {
            if (VerifySearchRecordDisplayed())
            {
                foreach (var data in LeavePageSearchRecord)
                {
                    Console.WriteLine(data.Text);
                }
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
