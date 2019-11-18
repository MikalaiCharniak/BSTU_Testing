using _5element.PageObject.Test.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _5element.PageObject.Test
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new ChromeDriver("D:\\Univer\\4course_1sem\\SoftwareTesting\\Selenium_Drivers");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckComparisonProduct()
        {
            var homePage = new HomePage(_driver);
            homePage.GoToPage();
            var laptopSectionPage = homePage.GoToLaptopSectionPage();
            Assert.Pass();
        }
    }
}