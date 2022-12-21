using AventStack.ExtentReports;
using CommonFramework.ExtensionMethods;
using CommonFramework.Screenshots;
using CommonFramework.Utility;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages.Admin
{
    public class Admin:BasePage
    {
        #region Locators
        By adminTab => GetByXPathElementBySpanText("Admin");
        By userName => GetByXPathUsingLabel("Username");
        By searchUserName => By.XPath("//div[@class='oxd-table-card-cell-checkbox']/parent::div/following-sibling::div/div");
        public IReadOnlyCollection<IWebElement> AdminPageUsersTableData;
        public IReadOnlyCollection<IWebElement> AdminPageSearchRecord;
        public AddUser AddUser { get; set; }    
        #endregion

        #region Actions
        public Admin()
        {
            AddUser = new AddUser();
        }
        public void ClickOnAdminTab()
        {
            ShortWait(adminTab);
            ClickOnElement(adminTab);
            extentReport.Test.Log(Status.Info, "Navigated to Admin page");
        }

        public bool VerifyListOfUsersDisplayed()
        {
            ShortWait(tableData);
            AdminPageUsersTableData = GetMultipleElements(tableData);
            foreach (var data in AdminPageUsersTableData)
            {
                if (!data.Displayed)
                    return false;
            }
            extentReport.Test.Log(Status.Info, "List of users is displayed");
            return true;
        }

        public void SearchForUser()
        {
            ShortWait(tableData);
            AdminPageUsersTableData = GetMultipleElements(tableData);
            foreach(var data in AdminPageUsersTableData)
            {
                if (data.Text.Equals(GetText(searchUserName)))
                {
                    ShortWait(userName);
                    SendKeysToField(userName, data.Text);
                    break;
                }
            }            
            ClickOnSubmitButton();
            extentReport.Test.Log(Status.Info, "User is searched");
        }

        public bool VerifySearchRecordDisplayed()
        {
            ShortWait(tableData);
            AdminPageSearchRecord = GetMultipleElements(tableData);
            foreach (var data in AdminPageSearchRecord)
            {
                if (!data.Displayed)
                    return false;
            }
            extentReport.Test.Log(Status.Info, "Search record displayed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "AdminPageTest Passed", Screenshots.TakeScreenShot("AdminPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "AdminPageTest Failed", Screenshots.TakeScreenShot("AdminPageScreenshot.png"));
            return true;
        }
        #endregion
    }
}
