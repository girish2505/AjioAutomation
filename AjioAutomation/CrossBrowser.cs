using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AjioAutomation
{
    public enum Browsers
    {
        Chrome, Firefox, IE
    }
    public class CrossBrowser:Base.BaseClass
    {
        private Browsers browserType;
        public CrossBrowser(Browsers browser)
        {
            browserType = browser;
        }

        [SetUp]
        public void TestSetup()
        {
            SelectBrowser(browserType);
        }

        public void SelectBrowser(Browsers driverType)
        {
            if (driverType == Browsers.Chrome)
                driver = new ChromeDriver();
            else if (driverType == Browsers.Firefox)
                driver = new FirefoxDriver();
            else driver = new InternetExplorerDriver();
        }
    }
}
