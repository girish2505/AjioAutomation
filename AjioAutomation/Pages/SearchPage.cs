using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation.Pages
{
    public class SearchPage
    {
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "searchVal")]
        [CacheLookup]
        public IWebElement searchbtn;
    }
}
