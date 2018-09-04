using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class TestBase 
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            //FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox ESR\firefox.exe";
            //options.UseLegacyImplementation = true;
            //driver = new FirefoxDriver(options);
            //baseURL = "http://localhost/";
            //verificationErrors = new StringBuilder();

            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}

