using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AjioAutomation.DoActions
{
    public class Action
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
            Assert.AreEqual(driver.Url, "https://www.ajio.com/");

            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(10000);

            login.startbtn.Click();
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(driver.Url, "https://www.ajio.com/");

        }
        public static void SearchKey(IWebDriver driver)
        {
            Pages.Search search = new Pages.Search(driver);

            search.searchbtn.Click();
            System.Threading.Thread.Sleep(1000);

            search.searchbtn.SendKeys("Shoes");

            search.searchbtn.SendKeys(Keys.Enter);

            string expected = "Footwear";
            string actual = driver.FindElement(By.XPath("//div[contains(text(),'Footwear')]")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("Successfull");
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElement, "No such element found");
            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,200)");
            System.Threading.Thread.Sleep(2000);

            search.product.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            System.Threading.Thread.Sleep(1000);

            Base.BaseClass.Takescreenshot();

            System.Threading.Thread.Sleep(1000);
        }
        public static void AddToBag(IWebDriver driver)
        {
            Pages.AddToBag add = new Pages.AddToBag(driver);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,200)");
            System.Threading.Thread.Sleep(1000);

            add.sizebtn.Click();
            System.Threading.Thread.Sleep(1000);

            add.addToBag.Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreEqual(driver.Url, "https://www.ajio.com/puma-popcat-20-slides-with-logo-print/p/460953070_black");
        }
        public static void PlaceOrder(IWebDriver driver)
        {
            Pages.ApplyCoupon order = new Pages.ApplyCoupon(driver);

            order.bagbtn.Click();
            System.Threading.Thread.Sleep(1000);

            string expected = "My Bag";
            string actual = driver.FindElement(By.XPath("//span[contains(text(),'My Bag')]")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            try
            {
                Console.WriteLine("Successfull");
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElement, "No such element found");
            }

            order.coupon.Click();
            System.Threading.Thread.Sleep(1000);

            order.applyBtn.Click();
            System.Threading.Thread.Sleep(1000);

            order.ProceedBtn.Click();
            System.Threading.Thread.Sleep(1000);

            order.ProceedToPayment.Click();
            System.Threading.Thread.Sleep(1000);
        }
        public static void Payment(IWebDriver driver)
        {
            Pages.PlaceOrder pay = new Pages.PlaceOrder(driver);

            pay.codBtn.Click();
            System.Threading.Thread.Sleep(1000);

            pay.conformOrder.Click();
            System.Threading.Thread.Sleep(1000);

        }
        public static void Signout(IWebDriver driver)
        {
            Pages.SignOut signout = new Pages.SignOut(driver);

            signout.signOut.Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
