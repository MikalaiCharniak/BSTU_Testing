using OpenQA.Selenium;
using System.Threading;

namespace _5element.PageObject.Test.PageObjects
{
    public class LaptopSectionPage
    {
        public const string pageUrl = "https://5element.by/";
        private readonly IWebDriver _driver;
        public LaptopSectionPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public LaptopSectionPage(IWebDriver driver, string routeFrom)
        {
            _driver = driver;
            switch (routeFrom)
            {
                case Constants.PageURLs.homePageUrl:
                    InitPageFromHomePage();
                    break;
            }
        }

        private void InitPageFromHomePage()
        {
            _driver.FindElement(By.XPath("//nav[@class='menu-goods']/ul/li[8]/a")).Click();
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//div[@class='sidebar-menu-item-body  ']/ul/li[1]/a")).Click();
            Thread.Sleep(1000);
        }

        public void GoToPage()
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
