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
            app = ApplicationManager.GetInstance();
        }
    }
}

