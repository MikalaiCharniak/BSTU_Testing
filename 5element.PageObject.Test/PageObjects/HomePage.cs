using OpenQA.Selenium;


namespace _5element.PageObject.Test.PageObjects
{
    public class HomePage
    {
        public const string pageUrl = "https://5element.by/";
        private readonly IWebDriver _driver;
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