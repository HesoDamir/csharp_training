using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            GoToContactPage();
            ContactData contact = new ContactData("Damir");
            contact.MiddleName = "Khabi";
            FillContactForm(contact);
            SubmitContactCreation();
            Logout();
        }
       
    }
}
