﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumHT5
{
    public class EdgeTests : Main
    {

        [SetUp]
        public override void Setup()
        {
            driver = new ChromeDriver();

        }
    }
}