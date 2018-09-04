using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Damir");
            contact.MiddleName = "Khabi";

            app.Contacts.Create(contact);
            app.Navigator.Logout();
        }
       
    }
}
