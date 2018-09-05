using NUnit.Framework;
using OpenQA.Selenium;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    public class TestBase 
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}

