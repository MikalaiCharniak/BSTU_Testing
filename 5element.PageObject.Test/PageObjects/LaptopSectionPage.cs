using _5element.PageObject.Test.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace _5element.PageObject.Test.PageObjects
{
    public class LaptopSectionPage : Page
    {
        private readonly IWebDriver _driver;
        private const string _addToCompareButtonsXPath = ".//div[@title='В сравнение']";
        private const string _compareWindowXPath = ".//a[@class='js-bottom-compare']";
        private IWebElement _compareWindow;
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
        public void AddLaptopsToCompare(int laptopsNumber)
        {
            var addToCompareButtons = _driver.FindElements(By.XPath(_addToCompareButtonsXPath));
            for (int i = 1; i < laptopsNumber+1; i++)
            {
                ScrollToElement(_driver, addToCompareButtons[i]);
                Thread.Sleep(5000);
                addToCompareButtons[i].Click();
            }
        }
        public void OpenCompareWindow()
        {
            Thread.Sleep(10000);
            _compareWindow = _driver.FindElement(By.XPath(_compareWindowXPath));
            _compareWindow.Click();
        } 
        private void InitPageFromHomePage()
        {
            _driver.FindElement(By.XPath("//nav[@class='menu-goods']/ul/li[8]/a")).Click();
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//div[@class='sidebar-menu-item-body  ']/ul/li[1]/a")).Click();
            Thread.Sleep(1000);
        }
    }
}
