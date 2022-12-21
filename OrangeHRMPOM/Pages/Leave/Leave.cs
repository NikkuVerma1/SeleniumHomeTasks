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

namespace OrangeHRMPOM.Pages.Leave
{
    public class Leave:BasePage
    {
        #region Locators
        By leaveTab => GetByXPathElementBySpanText("Leave");
        By date => By.XPath("//div[@class='oxd-table-card-cell-checkbox']/parent::div/following-sibling::div");
        By fromDateField => By.XPath("//label[text()='From Date']/parent::div/following-sibling::div/div/div/input");
        By toDateField => By.XPath("//label[text()='To Date']/parent::div/following-sibling::div/div/div/input");
        string[] dateArray;
        string fromDate="";
        string toDate="";
        public IReadOnlyCollection<IWebElement> LeavePageSearchRecord;
        #endregion

        #region Actions
        public void ClickOnLeaveTab()
        {
            ShortWait(leaveTab);
            ClickOnElement(leaveTab);
            extentReport.Test.Log(Status.Info, "Navigated to Leave page");
        }

        public void GetFromAndToDates()
        {
            ShortWait(date);
            dateArray=SplitDateString(date);
            if (dateArray.Length > 1)
            {
                fromDate=dateArray[0];
                toDate = dateArray[2];
            }
            else
            {
                fromDate = dateArray[0];
                toDate = dateArray[0];
            }
            Console.WriteLine(fromDate+" "+toDate);
            extentReport.Test.Log(Status.Info, "Got From and To dates of leave");
        }

        public void EnterFromAndToDates()
        {
            DeleteDefaulAndSendKeysToField(fromDateField, fromDate);
            LongWait(toDateField);
            DeleteDefaulAndSendKeysToField(toDateField, toDate);
            extentReport.Test.Log(Status.Info, "From and To dates are entered");
        }

        public bool VerifySearchRecordDisplayed()
        {
            ShortWait(tableData);
            LeavePageSearchRecord = GetMultipleElements(tableData);
            foreach (var data in LeavePageSearchRecord)
            {
                if (!data.Displayed)
                    return false;
            }
            extentReport.Test.Log(Status.Info, "Search record displayed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "LeavePageTest Passed", Screenshots.TakeScreenShot("LeavePageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "LeavePageTest Failed", Screenshots.TakeScreenShot("LeavePageScreenshot.png"));
            return true;
        }
        #endregion
    }
}
