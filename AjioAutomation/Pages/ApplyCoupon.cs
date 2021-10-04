using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AjioAutomation.Pages
{
    public class ApplyCoupon
    {
        public ApplyCoupon(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "ic-cart")]
        [CacheLookup]
        public IWebElement bagbtn;

        [FindsBy(How = How.Name, Using = "vouchers")]
        [CacheLookup]
        public IWebElement coupon;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Apply')]")]
        [CacheLookup]
        public IWebElement applyBtn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Proceed to shipping')]")]
        [CacheLookup]
        public IWebElement ProceedBtn;

        [FindsBy(How = How.ClassName, Using = "payment-btn")]
        [CacheLookup]
        public IWebElement ProceedToPayment;
    }

}
