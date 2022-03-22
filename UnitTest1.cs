using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace FirstWebTest
{
    [TestClass]
    public class Test
    {
        private IWebDriver driver;
        private string baseURL;
        private string aerologicalDiagramURL;

        private By fiveDayWeatherForecast = By.XPath("//a[@title='Detailed five-day weather forecast']");
        private By SkewTLogP = By.XPath("//a[@title='Skew-T log-P diagram']");

        [TestInitialize]
        public void SetupTest()
        {
            this.driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            this.baseURL = "https://meteo.paraplan.net/en/";
            this.aerologicalDiagramURL = "https://meteo.paraplan.net/en/forecast/saint-petersburg/aerological_diagram/";

            this.driver.Navigate().GoToUrl(this.baseURL);
            this.driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestCheck()
        {
            IsElementVisible(fiveDayWeatherForecast);
            this.driver.FindElement(fiveDayWeatherForecast).Click();

            IsElementVisible(By.XPath("//span[contains(text(),'Five-day weather')]"));

            IsElementVisible(SkewTLogP);
            this.driver.FindElement(SkewTLogP).Click();

            Assert.AreEqual(this.driver.Url, aerologicalDiagramURL);
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.driver.Close();
            this.driver.Quit();
        }

        public void IsElementVisible(By element, int timeoutSecs = 10)
        {
            new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
        }
    }
}
