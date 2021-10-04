using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AjioAutomation.Pages
{
    public class SignOut
    {
        public SignOut(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign Out')]")]
        [CacheLookup]
        public IWebElement signOut;
    }
}
