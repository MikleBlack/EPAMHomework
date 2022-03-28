using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.WebDriver;

namespace TestProject1.WebObj
{
    class BaseElement:IWebElement
    {
        private IWebDriver _driver = BrowserSelect.GetDriver();
        protected By _locator;
        protected IWebElement _element;
        public BaseElement(By locator)
        {
            _locator = locator;
        }

        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            AssertIsOpen(_locator);
            BrowserSelect.GetDriver().FindElement(_locator).Click();
        }

        public void JSClick()
        {
            AssertIsOpen(_locator);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)BrowserSelect.GetDriver();
            executor.ExecuteScript("arguments[0].click();", GetElement());
        }

        public IWebElement GetElement()
        {
            try
            {
                _element = BrowserSelect.GetDriver().FindElement(_locator);
            }
            catch(Exception)
            {
                throw;
            }
            return _element;
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            AssertIsOpen(_locator);
            BrowserSelect.GetDriver().FindElement(_locator).SendKeys(text);
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void AssertIsOpen(By _titleLocator, int timeoutSecs = 10)
        {
            new WebDriverWait(BrowserSelect.GetDriver(), TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(_titleLocator));
        }
    }
}
