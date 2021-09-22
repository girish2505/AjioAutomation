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

            test.Log(Status.Pass, "Test PAsses");
            reports.Flush();
        }

        [Test]
        public void SearchPage()
        {
            DoActions.Action.SearchKey(driver);
            Takescreenshot();
        }
    }
}