using AventStack.ExtentReports;
using CommonFramework.ExtensionMethods;
using CommonFramework.Screenshots;
using CommonFramework.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMPOM.Pages.Login
{
    public class Login : BasePage
    {
        #region Locators
        By userNameField => GetByXPathElementByInputName("username");
        By passwordField => GetByXPathElementByInputName("password");
        By loginButton => By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--main orangehrm-login-button']");
        public string URLAfterLogin => GetURL();
        #endregion

        #region Actions
        public void LaunchApplication(string url)
        {
            NavigateToURL(url);
            extentReport.Test.Log(Status.Info, "Application is launched");
        }

        public void EnterCredentials(string username, string passwd)
        {
            ShortWait(userNameField);
            SendKeysToField(userNameField, username);
            SendKeysToField(passwordField, passwd);
            extentReport.Test.Log(Status.Info, "Credentials (Username: " + username + ", Password: " + passwd + ") are entered");
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
            extentReport.Test.Log(Status.Info, "Login button is clicked");
            if (extentReport.Test.Status == Status.Pass)
                extentReport.Test.Log(Status.Pass, "LoginPageTest Passed", Screenshots.TakeScreenShot("LoginPageScreenshot.png"));
            else
                extentReport.Test.Log(Status.Fail, "LoginPageTest Failed", Screenshots.TakeScreenShot("LoginPageScreenshot.png"));
        }
        #endregion
    }
}
