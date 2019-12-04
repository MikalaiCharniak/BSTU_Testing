using OpenQA.Selenium;
using TestFramework.Core.Driver;

namespace TestFramework.Areas._5element.Steps
{
    public class Steps
    {
        private static IWebDriver _driver;

        public static void InitBrowser()
        {
            _driver = DriverInstance.GetInstance();
        }

        public static void CloseBrowser()
        {
            DriverInstance.CloseBrowser();
        }
    }
}