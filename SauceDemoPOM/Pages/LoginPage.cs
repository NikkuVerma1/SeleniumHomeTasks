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
using AventStack.ExtentReports.Model;

namespace SauceDemoPOM.Pages
{
    public class LoginPage:UIUtility
    {
        #region Locators
        By element;
        private By userName => GetByXPathElementById("user-name");
        private By password => GetByXPathElementById("password");
        private By loginButton => GetByXPathElementById("login-button");
        public string URLAfterLogin => GetURL();        
        #endregion

        #region Actions
        public void LaunchApplication(string url)
        {
            NavigateToURL(url);
            extentReport.Test = extentReport.Report.CreateTest("LoginTest").Info("Test Started");
            extentReport.Test.Log(Status.Info, "Application is launched");
        }

        public void EnterCredentials(string username, string passwd)
        {
            SendKeysToField(userName, username);
            SendKeysToField(password, passwd);            
            extentReport.Test.Log(Status.Info, "Credentials (Username: " + username + ", Password: "+ passwd + ") are entered");
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
            extentReport.Test.Log(Status.Info, "Login button is clicked");
            if (extentReport.Test.Status == Status.Pass)
            {
                extentReport.Test.Log(Status.Pass, "LoginTest Passed", Screenshots.TakeScreenShot("LoginPageScreenshot.png"));                
            }
            else
            {
                extentReport.Test.Log(Status.Fail, "LoginTest Failed", Screenshots.TakeScreenShot("LoginPageScreenshot.png"));                
            }
        }
        #endregion
        
    }
}
