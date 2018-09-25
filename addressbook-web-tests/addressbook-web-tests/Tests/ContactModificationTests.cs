﻿using NUnit.Framework;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData contact = new ContactData("Damir");
            contact.LastName = "Khabi";

            ContactData newData = new ContactData("Damir1");
            newData.LastName = "Khabi1";

            app.Navigator.GoToHomePage();
            if (!app.Contacts.EditOfContactIsPresent())
            {
                app.Contacts.Create(contact);
            }
            
            app.Contacts.Modify(newData);
        }

    }
}
