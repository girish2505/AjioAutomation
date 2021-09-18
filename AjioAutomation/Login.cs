using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation
{
    public class Login
    {
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='appContainer']/div[1]/div/header/div[1]/ul/li[1]/span")]
        [CacheLookup]
        public IWebElement loginBtn;

        [FindsBy(How = How.CssSelector, Using = "body.noScroll:nth-child(2) div.regular-store div.header-wrapper:nth-child(1) div.main-header.dodShadow div.guest-header div.modal.fade.in.modal-sign-in-up.referral-modal-sign-in-up div.modal-dialog div.modal-content div.modal-login-container form.login-form.num-email-form div:nth-child(3) div:nth-child(1) label:nth-child(1) > input.username")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.ClassName, Using = "login-btn")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//header/div[1]/ul[1]/li[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/div[3]/input[1]")]
        [CacheLookup]
        public IWebElement startbtn;

        [FindsBy(How = How.Name, Using = "searchVal")]
        [CacheLookup]
        public IWebElement searchbtn;
    }
}
