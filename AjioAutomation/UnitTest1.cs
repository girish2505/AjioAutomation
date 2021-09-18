using NUnit.Framework;
using OpenQA.Selenium;

namespace AjioAutomation
{
    public class Tests:Base.BaseClass
    {
        [Test]
        public void LoginPage()
        {
            DoActions.Action.LoginToAjio(driver);
            DoActions.Action.SearchKey(driver);
            Takescreenshot();
        }
    }
}