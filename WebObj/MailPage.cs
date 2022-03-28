using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.WebDriver;

namespace TestProject1.WebObj
{
    public class MailPage : BasePage
    {
        private string theme = "Test";
        private readonly BaseElement mailTitle = new BaseElement(By.XPath("//input[@class = 'container--H9L5q size_s--3_M-_' and @name = 'Subject']"));
        private readonly BaseElement messageBody = new BaseElement(By.XPath("//div[@contenteditable = 'true' and @role = 'textbox']"));
        private readonly BaseElement saveDraft = new BaseElement(By.XPath("//span[@class = 'button2 button2_base button2_hover-support js-shortcut']"));
        private readonly BaseElement closeEmailBox = new BaseElement(By.XPath("//button[@class = 'container--2lPGK type_base--rkphf color_base--hO-yz' and @title = 'Закрыть']"));
        private readonly BaseElement openSidebar = new BaseElement(By.XPath("//div[@aria-label = 'roman_morozov181952@mail.ru']"));
        private readonly BaseElement logout = new BaseElement(By.LinkText("Выйти"));
        private readonly BaseElement draftButton = new BaseElement(By.XPath("//a[@title = 'Черновики']"));
        private readonly BaseElement checkTitle = new BaseElement(By.XPath("//span[@class = 'llc__subject']//span[text() = 'Test']/ancestor::a//button[@class = 'll-av ll-av_centered ll-av_size_common']"));
        private readonly BaseElement deleteDraft = new BaseElement(By.XPath("//span[@title = 'Удалить']"));
        private readonly BaseElement wholePage = new BaseElement(By.XPath("//html[@lang = 'ru_RU']"));


        private static readonly By HomeLbl = By.ClassName("letter-list__react");
        public MailPage() : base(HomeLbl, "Mail Page") { }

        public void CreatingDraft()
        {
            BrowserSelect.GetDriver().Navigate().GoToUrl("https://e.mail.ru/compose");
            mailTitle.SendKeys(theme);
            messageBody.SendKeys("Shekera Mikhail");
            saveDraft.Click();
            closeEmailBox.Click();
            Logout();
        }

        public void DeletingDraft()
        {
            BrowserSelect.GetDriver().Navigate().GoToUrl("https://e.mail.ru/drafts");
            checkTitle.Click();
            wholePage.SendKeys(Keys.Delete);
            Logout();
        }

        private void Logout()
        {
            openSidebar.Click();
            logout.Click();
        }
    }
}
