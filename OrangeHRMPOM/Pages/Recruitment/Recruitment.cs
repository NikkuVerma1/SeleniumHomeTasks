using AventStack.ExtentReports;
using CommonFramework.ExtensionMethods;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages.Recruitment
{
    public class Recruitment:BasePage
    {
        #region Locators
        By recruitmentTab => GetByXPathElementBySpanText("Recruitment");
        public AddCandidate AddCandidate { get; set; }
        #endregion

        #region Actions
        public Recruitment()
        {
            AddCandidate = new AddCandidate();
        }
        public void ClickOnRecruitmentTab()
        {
            ShortWait(recruitmentTab);
            ClickOnElement(recruitmentTab);
            extentReport.Test.Log(Status.Info, "Navigated to Recruitment page");
        }
        #endregion
    }
}
