using AventStack.ExtentReports;
using CommonFramework.Screenshots;
using CommonFramework.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages
{
    public class BasePage:UIUtility
    {
        #region Locators
        public By submitButton => By.XPath("//button[@type='submit']");
        public By addButton => By.XPath("//i[@class='oxd-icon bi-plus oxd-button-icon']");
        public By tableData => By.XPath("//div[@class='oxd-table-cell oxd-padding-cell']");
        public By successMessage => By.XPath("//div[@class='oxd-toast oxd-toast--success oxd-toast-container--toast']");
        #endregion

        #region Actions
        public void ClickOnSubmitButton()
        {
            ShortWait(submitButton);
            ClickOnElement(submitButton);
            extentReport.Test.Log(Status.Info, "Submit button is clicked");
        }

        public void ClickOnAddButton()
        {
            ShortWait(addButton);
            ClickOnElement(addButton);
            extentReport.Test.Log(Status.Info, "Navigated to Add page");
        }

        public bool IsPersonAdded()
        {
            ShortWait(successMessage);
            extentReport.Test.Log(Status.Info, "Success message displayed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "Test Passed", Screenshots.TakeScreenShot("Screenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "Test Failed", Screenshots.TakeScreenShot("Screenshot.png"));
            return DisplayedOrNot(successMessage);
        }
        #endregion
    }
}
