using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AjioAutomation.Pages
{
    public class AddToBag
    {
        public AddToBag(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'10')]")]
        [CacheLookup]
        public IWebElement sizebtn;

        [FindsBy(How = How.XPath, Using = "//div[@class ='btn-gold']")]
        [CacheLookup]
        public IWebElement addToBag;
    }
}
