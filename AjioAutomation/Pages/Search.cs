using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AjioAutomation.Pages
{
    public class Search
    {
        public Search(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "searchVal")]
        [CacheLookup]
        public IWebElement searchbtn;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/a[1]/div[1]/div[1]/img[1]")]
        [CacheLookup]
        public IWebElement product;
    }
}
