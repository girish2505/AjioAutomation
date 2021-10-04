using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AjioAutomation.Pages
{
    public class PlaceOrder
    {
        public PlaceOrder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/div[5]/div[1]")]
        [CacheLookup]
        public IWebElement codBtn;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[2]/div[1]/form[1]/div[1]/div[2]/button[1]")]
        [CacheLookup]
        public IWebElement conformOrder;
    }
}
