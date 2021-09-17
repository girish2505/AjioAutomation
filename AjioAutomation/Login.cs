using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation
{
    public class Login
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='appContainer]/div[1]/div/header/div[1]/ul/li[1]/span")]
        [CacheLookup]
        public IWebElement loginBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='login - modal']/div/div/div[2]/div/form/div[2]/div[1]/label/input")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.XPath, Using = "//*[@id='login - modal']/div/div/div[2]/div/form/div[2]/div[2]/input")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='pwdInput']")]
        [CacheLookup]
        public IWebElement password;
    }
}
