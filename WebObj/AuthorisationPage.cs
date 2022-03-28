using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.WebObj
{
    public class AuthorisationPage:BasePage
    {
        private readonly BaseElement userNameFeild = new BaseElement(By.XPath("//input[@name = 'username']"));
        private readonly BaseElement passFeild = new BaseElement(By.XPath("//input[@name = 'password']"));
        private readonly BaseElement passButton = new BaseElement(By.XPath("//button[@data-test-id = 'next-button']"));
        private readonly BaseElement loginButton = new BaseElement(By.XPath("//button[@data-test-id = 'submit-button']"));

        private static readonly By HomeLbl = By.ClassName("wrapper-0-2-13");
        public AuthorisationPage() : base(HomeLbl, "Home Page") { }

        public void Authorisation()
        {
            userNameFeild.SendKeys("roman_morozov181952@mail.ru");
            passButton.Click();
            passFeild.SendKeys("a6wpS8056s");
            loginButton.Click();
        }
    }
}
