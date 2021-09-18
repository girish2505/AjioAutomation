using log4net;
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

        private static readonly ILog log = LogManager.GetLogger(typeof(ITest));

        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void start_Browser()
        {
            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                log.Info("Entering Setup");

                driver = new ChromeDriver();

                driver.Manage().Window.Maximize();

                System.Threading.Thread.Sleep(200);

                driver.Url = "https://www.ajio.com/";

                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
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
