using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.ajio.com/";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
