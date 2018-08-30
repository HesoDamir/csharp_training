﻿using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests.Helpers
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL; 
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }
        public void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
