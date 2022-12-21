using AventStack.ExtentReports.Gherkin.Model;
using OrangeHRMPOM.Pages.Login;
using OrangeHRMTest.BaseTestClass;
using TechTalk.SpecFlow;

namespace OrangeHRMTest.Hooks
{
    [Binding]
    public sealed class OrangeHRMHooks:BaseTest
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            StartTest();
            extentReport.Test = extentReport.Report.CreateTest(ScenarioContext.Current.ScenarioInfo.Title).Info("Test Started");
        }

        [BeforeScenario("recruitment")]
        [BeforeScenario("time")]
        [BeforeScenario("leave")]
        [BeforeScenario("admin")]
        public void LoginToApplication()
        {
            Login login = new Login();
            login.LaunchApplication(config.ApplicationURL);
            login.EnterCredentials(config.Username, config.Password);
            login.ClickOnLoginButton();
        }        

        [AfterScenario]
        public void AfterScenario()
        {
            EndTest();
        }
    }
}