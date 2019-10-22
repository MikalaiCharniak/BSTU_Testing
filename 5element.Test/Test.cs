using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _5element.Test
{
    public class Tests
    {
        private IWebDriver driver;
        private int expectedCountProductsInCart;
        private string expectedHierarchyNavigation;

        [SetUp]
        public void startBrowser()
        {
            expectedCountProductsInCart = 2;
            expectedHierarchyNavigation = "Главная Услуги Доставка и самовывоз";
            driver = new ChromeDriver("D:\\Univer\\4course_1sem\\SoftwareTesting\\Selenium_Drivers");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckDeliveryPage()
        {
            driver.Url = "https://5element.by/";
            driver.FindElement(By.XPath("//*[@class='header-nav-list']/li[2]/a")).Click();
            var firstTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[1]")).GetAttribute("title");
            var secondTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[2]")).GetAttribute("title");
            var thirdTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/span")).GetAttribute("innerHTML");
            var HierarchyNavigation = $"{firstTitle} {secondTitle} {thirdTitle}";
            Assert.AreEqual(expectedHierarchyNavigation, HierarchyNavigation);
        }


        [Test]
        public void CheckAddingProductsToCart()
        {
            driver.Url = "https://5element.by/";
            driver.FindElement(By.XPath("//nav[@class='menu-goods']/ul/li[8]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='sidebar-menu-item-body  ']/ul/li[1]/a")).Click();
            Thread.Sleep(1000);
            var cartButtons = driver.FindElements(By.XPath("//div[@class='row flex-buy-buttons-mob-listing']/button[1]"));
            Thread.Sleep(1000);
            for (int i = 0; i < expectedCountProductsInCart; i++)
            {
                cartButtons[i].SendKeys(Keys.Space);
                Thread.Sleep(1000);
                try
                {
                    driver.FindElement(By.XPath("//button[@class='mfp-close']")).Click();
                }
                catch (Exception ex)
                {
                    Thread.Sleep(1000);
                }
                Thread.Sleep(10000);
            }
            Thread.Sleep(1000);
            var cartProductCount = driver.FindElement(By.XPath("//span[@class='header-elements-cart-qty ']")).GetAttribute("innerHTML");
            Thread.Sleep(1000);
            Assert.AreEqual(expectedCountProductsInCart, int.Parse(cartProductCount));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}