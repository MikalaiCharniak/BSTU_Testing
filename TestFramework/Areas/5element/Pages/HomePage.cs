using OpenQA.Selenium;
using System.Threading;
using TestFramework.Core.Abstractions;

namespace TestFramework.Areas._5element.Pages
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void TestBrowser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://5element.by/";
            Thread.Sleep(1000);
            _driver.Quit();
        }
    }
}