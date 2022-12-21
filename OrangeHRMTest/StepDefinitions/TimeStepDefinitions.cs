using CommonFramework.Base;
using CommonFramework.Utility;
using OrangeHRMPOM.Pages.Login;
using OrangeHRMPOM.Pages.Time;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public sealed class TimeStepDefinitions : Time
    {
        [Given(@"I clicked on time tab")]
        public void GivenIClickedOnTimeTab()
        {
            ClickOnTimeTab();
        }

        [Then(@"I should see list of employees and their pending timesheet period")]
        public void ThenIShouldSeeListOfEmployeesAndTheirPendingTimesheetPeriod()
        {
            if (DisplayUserList())
            {
                foreach (var data in TimePageTableData)
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
