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

namespace OrangeHRMPOM.Pages.Time
{
    public class Time:BasePage
    {
        #region Locators
        By timeTab => GetByXPathElementBySpanText("Time");
        public IReadOnlyCollection<IWebElement> TimePageTableData;
        #endregion

        #region Actions
        public void ClickOnTimeTab()
        {
            ShortWait(timeTab);
            ClickOnElement(timeTab);
            extentReport.Test.Log(Status.Info, "Navigated to Time page");
        }

        public bool DisplayUserList()
        {
            ShortWait(tableData);
            TimePageTableData = GetMultipleElements(tableData);
            foreach (var data in TimePageTableData)
            {
                if(!data.Displayed)
                    return false;
            }
            extentReport.Test.Log(Status.Info, "Employees time list displayed");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "TimePageTest Passed", Screenshots.TakeScreenShot("TimePageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "TimePageTest Failed", Screenshots.TakeScreenShot("TimePageScreenshot.png"));
            return true;
        }
        #endregion
    }
}
