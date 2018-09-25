using NUnit.Framework;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            ContactData contact = new ContactData("Damir");
            contact.LastName = "Khabi";

            app.Navigator.GoToHomePage();
            if (!app.Contacts.EditOfContactIsPresent())
            {
                app.Contacts.Create(contact);
            }
            app.Contacts.Remove();
        }

    }
}
