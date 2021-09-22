﻿using log4net;
using log4net.Repository;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AjioAutomation.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        private static readonly ILog result = LogManager.GetLogger(typeof(ITest));

        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void start_Browser()
        {
            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                result.Info("Entering Setup");

                ChromeOptions options = new ChromeOptions();

                options.AddArgument("--disable-notifications");

                result.Info("Disabling notifications");

                driver = new ChromeDriver();

                driver.Manage().Window.Maximize();

                System.Threading.Thread.Sleep(200);

                driver.Url = "https://www.ajio.com/";

                result.Debug("navigating to url");

                result.Info("Exiting setup");

            }
            catch (Exception ex)
            {
                result.Error(ex.Message);
            }
        }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\Screenshot\text1.png");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
