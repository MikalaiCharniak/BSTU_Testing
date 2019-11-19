using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace _5element.PageObject.Test.Abstractions
{
    public abstract class Page
    {
        protected  IWebDriver _driver;
        private const string _searchUrl = "#/search/";
        private const string searchInputByXPath = ".//input[@id='q']";

        public virtual void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        private void OpenSearchInput()
        {
            var searchURL = $"{_driver.Url}{_searchUrl}";
            _driver.Navigate().GoToUrl(searchURL);
        }

        public void WriteSearchQuery(string searchVariable)
        {
            OpenSearchInput();
            var searchInput = _driver.FindElement(By.XPath(searchInputByXPath));
            searchInput.Clear();
            searchInput.SendKeys(searchVariable);
            Thread.Sleep(5000);
        }
    }
}