using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using TestProject1.Tests;
using TestProject1.WebObj;

namespace FirstWebTest
{
    [DeploymentItem(@"Resources")]
    [TestClass]
    public class Test:InitializeAndCleanup
    {
        private AuthorisationPage authorisationPage;
        private MailPage mailPage;

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "E:\\epamst\\ATStudy\\TestProject1\\Resources\\TestData.csv",
            "TestData#csv", DataAccessMethod.Sequential)]
        public void CreatingDraft()
        {
            var email = TestContext.DataRow["email"].ToString();
            var password = TestContext.DataRow["pass"].ToString();

            authorisationPage = new AuthorisationPage();
            authorisationPage.Authorisation(email, password);
            mailPage = new MailPage();
            mailPage.CreatingDraft();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "E:\\epamst\\ATStudy\\TestProject1\\Resources\\TestData.csv",
            "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DeletingFirstDraft()
        {
            var email = TestContext.DataRow["email"].ToString();
            var password = TestContext.DataRow["pass"].ToString();

            authorisationPage = new AuthorisationPage();
            authorisationPage.Authorisation(email, password);
            mailPage = new MailPage();
            mailPage.DeleteFirstDraft();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "E:\\epamst\\ATStudy\\TestProject1\\Resources\\TestData.csv",
            "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DeletingEachDraft()
        {
            var email = TestContext.DataRow["email"].ToString();
            var password = TestContext.DataRow["pass"].ToString();

            authorisationPage = new AuthorisationPage();
            authorisationPage.Authorisation(email, password);
            mailPage = new MailPage();
            mailPage.DeleteEachDraft();
        }

    }
}
