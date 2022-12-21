using CommonFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AventStack.ExtentReports;

namespace CommonFramework.Screenshots
{
    public class Screenshots : BaseSetup
    {
        public static MediaEntityModelProvider TakeScreenShot(string screenshotName)
        {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
        }
    }
}
