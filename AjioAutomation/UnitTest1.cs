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
        }

        [Test]
        public void ReadingData()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\ExcelData\TestData.xlsx");
        }
    }
}