using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests.Helpers
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL; 
        }
        public NavigationHelper GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
            return this;
        }
        public NavigationHelper GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        public NavigationHelper Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
        public NavigationHelper GoToContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
