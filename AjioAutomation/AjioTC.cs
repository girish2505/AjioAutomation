using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AjioAutomation
{
    [TestFixture("chrome")]
    //[TestFixture("firefox")]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class Tests : Base.BaseClass
    {
        public Tests(string browser) : base(browser) { }
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
            DoActions.Action.LoginToAjio(driver);
            DoActions.Action.SearchKey(driver);
        }
        [Test]
        public void AddToBag()
        {
            DoActions.Action.LoginToAjio(driver);
            DoActions.Action.SearchKey(driver);
            DoActions.Action.AddToBag(driver);
            Takescreenshot();
        }

        [Test]
        public void PlaceOrder()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Ajio application and placing an order");

            DoActions.Action.LoginToAjio(driver);
            DoActions.Action.SearchKey(driver);
            DoActions.Action.AddToBag(driver);
            DoActions.Action.PlaceOrder(driver);
            DoActions.Action.Payment(driver);
            Takescreenshot();

            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\Screenshot\text2.png").Build());
            test.Log(Status.Pass, "Test PAsses");
            reports.Flush();
        }
        [Test]
        public void Signout()
        {
            DoActions.Action.LoginToAjio(driver);
            DoActions.Action.Signout(driver);
        }

        [Test]
        public void Sendmail()
        {
            driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
            Pages.Email.ReadDataFromExcel(driver);
            Pages.Email.SendMail(driver);
        }
        [Test]
        public void InvalidLogin()
        {
            DoActions.Action.LoginToAjio(driver);
            string expected = "Please enter correct password and captcha";
            string actual = driver.FindElement(By.ClassName("error-msg")).Text;
            Console.WriteLine("Error Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            Takescreenshot();
        }
        [Test]
        public void InvalidSearch()
        {
            Pages.Search search = new Pages.Search(driver);

            search.searchbtn.Click();
            System.Threading.Thread.Sleep(1000);

            search.searchbtn.SendKeys("bsdydb");
            search.searchbtn.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            string expected = "Sorry! We couldn't find any matching items for";
            string actual = driver.FindElement(By.ClassName("fnl-slpsearch-firstLine")).Text;
            Console.WriteLine("Error Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            Takescreenshot();
        }
    }
}