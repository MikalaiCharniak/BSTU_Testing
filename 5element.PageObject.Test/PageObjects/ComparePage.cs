using OpenQA.Selenium;

namespace _5element.PageObject.Test.PageObjects
{
    public class ComparePage
    {
        private const string linkByXPath = ".//a[@href='/compare']";
        private readonly IWebDriver _driver;
        private const string compareProductsArrayByXPath = ".//div[@class='product-item product-item-shortblock item js-product-item']";

        public ComparePage(IWebDriver driver)
        {
            _driver = driver;
            var buttonGoToComparePage = _driver.FindElement(By.XPath(linkByXPath));
            _driver.Navigate().GoToUrl("https://5element.by/compare");
        }

        public bool CheckNumberOfComporasionProducts(int expectedNumber)
        {
            var productForCompare = _driver.FindElements(By.XPath(compareProductsArrayByXPath));
            var result = productForCompare.Count == expectedNumber ? true : false;
            return result;
        }
    }
}
