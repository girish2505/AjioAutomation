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
            driver.FindElement(By.XPath("//*[@id='appContainer']/div[1]/div/header/div[1]/ul/li[1]/span")).Click();
            System.Threading.Thread.Sleep(10000);

            driver.FindElement(By.XPath("//*[@id='login - modal']/div/div/div[2]/div/div/form/div[1]/div[1]/div[1]/div")).Click();
        }
        public static void EnterCedentials(IWebDriver driver)
        { 
            driver.FindElement(By.XPath("//*[@id='login - modal']/div/div/div[2]/div/form/div[2]/div[1]/label/input")).SendKeys(ExcelOperations.ReadData(1, "email")); ;
            System.Threading.Thread.Sleep(10000);

            driver.FindElement(By.XPath("//*[@id='login - modal']/div/div/div[2]/div/form/div[2]/div[2]/input")).Click();
            System.Threading.Thread.Sleep(10000);

            driver.FindElement(By.XPath("//*[@id='pwdInput']")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
