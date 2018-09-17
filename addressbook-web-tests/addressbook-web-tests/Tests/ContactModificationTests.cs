using NUnit.Framework;
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
            contact.MiddleName = "Khabi";

            ContactData newData = new ContactData("Damir1");
            newData.MiddleName = "Khabi1";
          
            app.Contacts.Modify(contact, newData);
        }

    }
}
