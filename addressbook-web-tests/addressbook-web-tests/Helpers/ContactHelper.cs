using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Helpers
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToContactPage();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Name);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            return this;
        }
     
    }
}
