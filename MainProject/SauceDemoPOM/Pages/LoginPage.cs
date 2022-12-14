using OpenQA.Selenium;
using CommonFramework.Utility;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Configuration;
using AventStack.ExtentReports;
using CommonFramework.Reports;
using CommonFramework.Screenshots;

namespace SauceDemoPOM.Pages
{
    public class LoginPage:UIUtility
    {
        #region Locators
        By element;
        private By userName => By.XPath("//input[@id='user-name']");
        private By password => By.XPath("//input[@id='password']");
        private By loginButton => By.XPath("//input[@id='login-button']");
        public string URLAfterLogin => GetURL();
        
        #endregion

        #region Actions
        public void LaunchApplication(string url)
        {

            NavigateToURL(url);
            extentReport.test = extentReport.report.CreateTest("LoginTest").Info("Test Started");
            extentReport.test.Log(Status.Info, "Application is launched");
        }
        public void EnterCredentials(string username, string passwd)
        {
            SendKeysToField(userName, username);
            SendKeysToField(password, passwd);            
            extentReport.test.Log(Status.Info, "Credentials are entered");
        }
        public void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
            extentReport.test.Log(Status.Info, "Login button is clicked");
            Screenshots.TakeScreenShot();
            extentReport.test.Log(Status.Info, "Screenshot is taken for reference");
            if (extentReport.test.Status == Status.Pass)
                extentReport.test.Log(Status.Pass, "LoginTest Passed");
            else
                extentReport.test.Log(Status.Fail, "LoginTest Failed");
        }
        
        #endregion
        
    }
}
