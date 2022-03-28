using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.WebDriver;

namespace TestProject1.Tests
{
    public class InitializeAndCleanup
    {

        protected static BrowserSelect Browser = BrowserSelect.Instance;

        [TestInitialize]
        public void SetupTest()
        {
            Browser = BrowserSelect.Instance;
            BrowserSelect.MaximizeWindow();
            BrowserSelect.NavigateTo(Configuration.StartURL);
        }

        [TestCleanup]
        public void CleanUp()
        {
            BrowserSelect.Quit();
        }
    }
}
