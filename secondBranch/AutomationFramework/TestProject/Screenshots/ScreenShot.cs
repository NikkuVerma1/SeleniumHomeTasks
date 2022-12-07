using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationFramework.Test;
using AutomationFramework.Pages;
using NUnit.Framework.Interfaces;
using TestProject.Test.BaseTestClass;
using AutomationFramework.Utilities.PageUtility;

namespace AutomationFramework.Screenshots
{
    internal class ScreenShot:BasePage
    {
        public static void TakeScreenShot()
        {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Nikku_Verma1\\source\\repos\\AutomationFramework\\TestProject\\Screenshots\\screenshot.png", ScreenshotImageFormat.Png);
            
        }
    }
}
