using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestFramework.Core.Abstractions
{
    public abstract class Page
    {
        protected IWebDriver _driver;

        public virtual void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}