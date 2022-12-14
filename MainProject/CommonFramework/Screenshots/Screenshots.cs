using CommonFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CommonFramework.Screenshots
{
    public class Screenshots : BaseClass
    {
        public static void TakeScreenShot()
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(ConfigurationManager.AppSettings["screenshotFilePath"], ScreenshotImageFormat.Png);

        }
    }
}
