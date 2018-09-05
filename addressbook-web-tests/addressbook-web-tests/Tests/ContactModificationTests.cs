using NUnit.Framework;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Damir1");
            newData.MiddleName = "Khabi1";
          
            app.Contacts.Modify(newData);
        }

    }
}
