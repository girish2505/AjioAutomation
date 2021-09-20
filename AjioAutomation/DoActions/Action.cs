using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AjioAutomation.DoActions
{
    class Action
    {
        public static void LoginToAjio(IWebDriver driver)
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\ExcelData\TestData.xlsx");
            Login login = new Login(driver);

            login.loginBtn.Click();
            System.Threading.Thread.Sleep(1000);

            login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(1000);

            login.continuebtn.Click();
            System.Threading.Thread.Sleep(1000);

            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(10000);

            login.startbtn.Click();
            System.Threading.Thread.Sleep(1000);

            login.searchbtn.Click();
            System.Threading.Thread.Sleep(1000);

        }
        public static void SearchKey(IWebDriver driver)
        {
            IWebElement MyElement = driver.FindElement(By.Name("searchVal"));
            MyElement.SendKeys(Keys.NumberPad7); MyElement.SendKeys(Keys.Down);
            MyElement.SendKeys(Keys.Enter);
        }
    }
}
