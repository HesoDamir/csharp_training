using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Helpers
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }
        public LoginHelper Login(AccountData account)
        {
            Type(By.Name("user"), account.UserName);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();

            return this;
        }

    }
}
