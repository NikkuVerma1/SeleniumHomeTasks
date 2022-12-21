using CommonFramework.Base;
using CommonFramework.Utility;
using OrangeHRMPOM.Pages.Admin;
using OrangeHRMPOM.Pages.Login;
using OrangeHRMPOM.Pages.Recruitment;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public sealed class AdminStepDefinitions : Admin
    {
        [Given(@"I clicked on admin tab")]
        public void GivenIClickedOnAdminTab()
        {
            ClickOnAdminTab();
        }

        [Then(@"list of users should be displayed")]
        public void ThenListOfUsersShouldBeDisplayed()
        {
            Console.WriteLine("List of users");
            if (VerifyListOfUsersDisplayed())
            {
                foreach (var data in AdminPageUsersTableData)
                {
                    if (data.Text is string)
                        Console.WriteLine(data.Text);
                }
            }
        }

        [When(@"I enter username in username field from list and click search button")]
        public void WhenIEnterUsernameInUsernameFieldFromListAndClickSearchButton()
        {
            SearchForUser();
        }

        [Then(@"related user record should be displayed")]
        public void ThenRelatedUserRecordShouldBeDisplayed()
        {
            if (VerifySearchRecordDisplayed())
            {
                foreach (var data in AdminPageSearchRecord)
                {
                    if (data.Text is string)
                        Console.WriteLine(data.Text);
                }
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [When(@"I click add button")]
        public void WhenIClickAddButton()
        {
            ClickOnAddButton();
        }

        [Then(@"I should be navigated to add user page")]
        public void ThenIShouldBeNavigatedToAddUserPage()
        {
            Console.WriteLine(GetURL());
        }

        [When(@"I select user role")]
        public void WhenISelectUserRole()
        {
            AddUser.SelectUserRole();
        }

        [When(@"I enter '([^']*)'")]
        public void WhenIEnter(string employeeInitial)
        {
            AddUser.EnterEmployeeName(employeeInitial);
        }

        [When(@"I select status")]
        public void WhenISelectStatus()
        {
            AddUser.SelectStatus();
        }

        [When(@"I key in '([^']*)'")]
        public void WhenIKeyIn(string username)
        {
            AddUser.EnterUserName(username);
        }

        [When(@"I type in '([^']*)' and '([^']*)'")]
        public void WhenITypeInAnd(string password, string confirmPassword)
        {
            AddUser.EnterPassword(password, confirmPassword);
        }

        [When(@"I submit details using save button")]
        public void WhenISubmitDetailsUsingSaveButton()
        {
            AddUser.SaveUser();
        }

        [Then(@"user should be added")]
        public void ThenUserShouldBeAdded()
        {
            if (AddUser.IsPersonAdded())
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
