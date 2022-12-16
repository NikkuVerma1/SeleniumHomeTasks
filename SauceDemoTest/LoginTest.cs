using SauceDemoPOM.Pages;
using SauceDemoTest.BaseTestClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest
{
    public class LoginTest:BaseTest
    {
        [Test]
        public void LoginPageTest()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LaunchApplication(GetAppConfigValue("applicationURL"));
            loginPage.EnterCredentials(config.Username, config.Password);
            loginPage.ClickOnLoginButton();
        }       
    }
}
