using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TestProject1.Tests;
using TestProject1.WebObj;

namespace FirstWebTest
{
    [TestClass]
    public class Test:InitializeAndCleanup
    {
        private AuthorisationPage authorisationPage;
        private MailPage mailPage;

        [TestMethod]
        public void CreatingDraft()
        {
            authorisationPage = new AuthorisationPage();
            authorisationPage.Authorisation();
            mailPage = new MailPage();
            mailPage.CreatingDraft();
        }

        [TestMethod]
        public void OpeningDraft()
        {
            authorisationPage = new AuthorisationPage();
            authorisationPage.Authorisation();
            mailPage = new MailPage();
            mailPage.DeletingDraft();
        }

    }
}
