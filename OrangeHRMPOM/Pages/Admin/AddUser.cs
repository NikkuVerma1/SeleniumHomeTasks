using AventStack.ExtentReports;
using CommonFramework.ExtensionMethods;
using CommonFramework.Screenshots;
using CommonFramework.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages.Admin
{
    public class AddUser:BasePage
    {
        #region Locators
        By userRole => By.XPath("//label[text()='User Role']/parent::div/following-sibling::div/div/div/div");
        By employeeName => By.XPath("//div[@class='oxd-autocomplete-text-input oxd-autocomplete-text-input--active']");
        By status => By.XPath("//label[text()='Status']/parent::div/following-sibling::div/div/div/div");
        By userName => GetByXPathUsingLabel("Username");   
        By password => GetByXPathUsingLabel("Password");   
        By confirmPassword => GetByXPathUsingLabel("Confirm Password");
        #endregion

        #region Actions
        public void SelectUserRole()
        {
            ShortWait(userRole);
            ClickOnElement(userRole);
            SelectFromDropDown();
            extentReport.Test.Log(Status.Info, "User role is selected");
        }

        public void EnterEmployeeName(string employeeInitial)
        {
            ShortWait(employeeName);
            ClickOnElement(employeeName);
            SelectFromDynamicDropDown(employeeInitial);
            extentReport.Test.Log(Status.Info, "Employee name is entered");
        }
        public void SelectStatus()
        {
            ShortWait(status);
            ClickOnElement(status);
            SelectFromDropDown();
            extentReport.Test.Log(Status.Info, "Status is selected");
        }

        public void EnterUserName(string username)
        {
            SendKeysToField(userName, username);
            extentReport.Test.Log(Status.Info, "User name is entered");
        }

        public void EnterPassword(string passwd, string confirmPasswd)
        {
            ShortWait(password);
            SendKeysToField(password, passwd);
            SendKeysToField(confirmPassword, confirmPasswd);
            extentReport.Test.Log(Status.Info, "Password is entered");
        }

        public void SaveUser()
        {
            Thread.Sleep(1000);
            ClickOnSubmitButton();
            extentReport.Test.Log(Status.Info, "User details are submitted");
        }
        #endregion
    }
}
