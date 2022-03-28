using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.WebDriver
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox
        }

        public static IWebDriver GetDriver(BrowserType type, int timeOutSec)
        {
            IWebDriver driver = null;

            switch(type)
            {
                case BrowserType.Chrome:
                    {
                        var chromeOptions = new OpenQA.Selenium.Chrome.ChromeOptions();
                        chromeOptions.AddArgument("disable-infobars");
                        driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeOptions);
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        var firefoxOptions = new OpenQA.Selenium.Firefox.FirefoxOptions();
                        driver = new OpenQA.Selenium.Firefox.FirefoxDriver(firefoxOptions);
                        break;
                    }
            }
            return driver;
        }
    }
}
