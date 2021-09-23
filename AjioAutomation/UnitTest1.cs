using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AjioAutomation
{
    public class Tests:Base.BaseClass
    {
        ExtentReports reports = ReportClass.Report();
        ExtentTest test;
        [Test]
        public void LoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Ajio Login Page");

            DoActions.Action.LoginToAjio(driver);
            Takescreenshot();
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\Screenshot\text1.png").Build());

            test.Log(Status.Pass, "Test PAsses");
            reports.Flush();
        }
        [Test]
        public void SearchPage()
        {
            DoActions.Action.SearchKey(driver);
            Takescreenshot();
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\Screenshot\text2.png").Build());
        }
        [Test]
        public void sendmail()
        {
            driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
            Pages.Email.ReadDataFromExcel(driver);
            Pages.Email.SendMail(driver);
        }
    }
}