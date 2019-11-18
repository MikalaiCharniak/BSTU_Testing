using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace _5element.PageObject.Test.Abstractions
{
    public abstract class Page
    {
        public virtual void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}
