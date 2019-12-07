using _5element.PageObject.Test.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace _5element.PageObject.Test
{
    public class Tests
    {
        private IWebDriver _driver;
        private int exptectedProductForCompare;
        private string searchVariable;
        [SetUp]
        public void StartBrowser()
        {
            exptectedProductForCompare = 2;
            searchVariable = "????????";
            _driver = new ChromeDriver("D:\\Univer\\4course_1sem\\SoftwareTesting\\Selenium_Drivers");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckComparisonProduct()
        {
            TestContext.AddTestAttachment(Path.GetTempFileName());
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
            TestContext.AddTestAttachment(Path.GetTempFileName());
        }

        [Test]
        public void CheckSearchFunction()
        {
            var homePage = new HomePage(_driver);
            homePage.GoToPage();
            homePage.WriteSearchQuery(searchVariable);
            var isSearchResultExist = SearchPanel.IsNotZeroResults(_driver)
                && !SearchPanel.IsNoResults(_driver);
            Assert.IsTrue(isSearchResultExist);
        }
    }
}