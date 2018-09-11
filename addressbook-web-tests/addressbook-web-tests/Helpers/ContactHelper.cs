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

        public ContactHelper Remove()
        {
            manager.Navigator.GoToHomePage();
            SelectContact();
            RemoveContact();
            AcceptRemove();
            return this;
        }

        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            ClickEditContact();
            FillContactForm(newData);
            ClickUpdate();
            return this;
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
            Type(By.Name("firstname"), contact.Name);
            Type(By.Name("middlename"), contact.MiddleName);
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.XPath("//input[@name='selected[]']")).Click();
            return this;
        }
        public ContactHelper AcceptRemove()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper ClickEditContact()
        {
            driver.FindElement(By.XPath("//img[@title='Edit']")).Click();
            return this;
        }
        public ContactHelper ClickUpdate()
        {
            driver.FindElement(By.XPath("//input[@name='update']")).Click();
            return this;
        }

    }
}
