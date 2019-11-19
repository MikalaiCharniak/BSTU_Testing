using _5element.PageObject.Test.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace _5element.PageObject.Test.PageObjects
{
    public class HomePage : Page
    {
        public const string pageUrl = "https://5element.by/";
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public LaptopSectionPage GoToLaptopSectionPage() => 
            new LaptopSectionPage(_driver, pageUrl);

        public void GoToPage() => 
            _driver.Navigate().GoToUrl(pageUrl);      
    }
}