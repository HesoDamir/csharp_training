using NUnit.Framework;
using System.Collections.Generic;
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

            List<ContactData> oldContacts = ContactData.GetAll();
            ContactData oldData = oldContacts[0];

            app.Navigator.GoToHomePage();
            if (!app.Contacts.EditOfContactIsPresent())
            {
                app.Contacts.Create(contact);
            }
            app.Contacts.Modify(oldData);

            List<ContactData> newContacts = ContactData.GetAll();
            oldContacts[0].Name = newData.Name;
            oldContacts[0].LastName = newData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

    }
}
