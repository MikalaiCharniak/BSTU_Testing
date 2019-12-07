using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestFramework.Core.Abstractions
{
    public abstract class Page
    {
        private string _url;
        public string PageUrl
        {
            get {
                return _url;
            }
            set {
                if (string.IsNullOrEmpty(_url))
                    _url = value;
            }
        }
        protected IWebDriver _driver;

        public virtual void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("scroll(0,754);");
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}