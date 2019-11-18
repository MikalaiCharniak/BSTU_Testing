using _5element.PageObject.Test.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace _5element.PageObject.Test
{
    public class Tests
    {
        private IWebDriver _driver;
        private int exptectedProductForCompare;
        [SetUp]
        public void StartBrowser()
        {
            exptectedProductForCompare = 2;
            _driver = new ChromeDriver("D:\\Univer\\4course_1sem\\SoftwareTesting\\Selenium_Drivers");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckComparisonProduct()
        {
            var homePage = new HomePage(_driver);
            homePage.GoToPage();
            var laptopSectionPage = homePage.GoToLaptopSectionPage();
            laptopSectionPage.AddLaptopsToCompare(2);
            laptopSectionPage.OpenCompareWindow();
            Thread.Sleep(1000);
            var compareWindow = new ComparePage(_driver);
            Thread.Sleep(1000);
            var result = compareWindow.CheckNumberOfComporasionProducts(exptectedProductForCompare);
            Assert.IsTrue(result);
        }
    }
}