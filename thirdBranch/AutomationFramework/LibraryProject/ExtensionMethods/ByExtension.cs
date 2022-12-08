﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.ExtensionMethods
{
    public static class ByExtension
    {
        static By element;
        public static By ByXPathOrByCSS(this By by, string s)
        {
            if (s.StartsWith("//"))
            {
                element= By.XPath(s);
                return element;
            }
            else
            {
                element= By.CssSelector(s);
                return element;
            }
        }

        
    }
}
