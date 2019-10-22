using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab.WebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("D:\\Univer\\4course_1sem\\SoftwareTesting\\Selenium_Drivers");
            driver.Manage().Window.Maximize();;
            driver.Url = "https://5element.by/";
            driver.FindElement(By.XPath("//*[@class='header-nav-list']/li[2]/a")).Click();
            var firstTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[1]")).GetAttribute("title");
            var secondTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/a[2]")).GetAttribute("title");
            var thirdTitle = driver.FindElement(By.XPath("//div[@class='breadcrumbs']/span")).GetAttribute("innerHTML");
            var HierarchyNavigation = $"{firstTitle} {secondTitle} {thirdTitle}";
            driver.Quit();
        }
    }
}
