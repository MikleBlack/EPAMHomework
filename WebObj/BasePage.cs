using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProject1.WebDriver;

namespace TestProject1.WebObj
{
    public class BasePage
    {
        protected By _titleLocator;
        protected string _title;
        public static string _titleForm;

        protected BasePage(By TitleLocator, string title)
        {
            _titleLocator = TitleLocator;
            _title = title;
            AssertIsOpen(_titleLocator);
        }

        //Возможно здесь будет ошибка
        public void AssertIsOpen(By _titleLocator, int timeoutSecs = 10)
        {
            new WebDriverWait(BrowserSelect.GetDriver(), TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(_titleLocator));
        }
    }
}
