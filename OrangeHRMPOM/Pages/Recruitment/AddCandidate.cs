using AventStack.ExtentReports;
using CommonFramework.ExtensionMethods;
using CommonFramework.Screenshots;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages.Recruitment
{
    public class AddCandidate:BasePage
    {
        #region Locators
        By firstNameField => By.Name("firstName");
        By lastNameField => By.Name("lastName");
        By emailField => GetByXPathUsingLabel("Email");
        By errorMessage => By.XPath("//span[@class='oxd-text oxd-text--span oxd-input-field-error-message oxd-input-group__message']");
        #endregion

        #region Actions
        public void EnterCandidateDetails(string firstName, string lastName, string email)
        {
            ShortWait(firstNameField);
            SendKeysToField(firstNameField,firstName);
            SendKeysToField(lastNameField,lastName);
            SendKeysToField(emailField,email);
            extentReport.Test.Log(Status.Info, "Candidate details are entered");
        }

        public bool IsErrorDisplayed()
        {
            extentReport.Test.Log(Status.Info, "Error message displayed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "RecruitmentPageTest Passed", Screenshots.TakeScreenShot("RecruitmentPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "RecruitmentPageTest Failed", Screenshots.TakeScreenShot("RecruitmentPageScreenshot.png"));
            return DisplayedOrNot(errorMessage);
        }
        #endregion
    }
}
