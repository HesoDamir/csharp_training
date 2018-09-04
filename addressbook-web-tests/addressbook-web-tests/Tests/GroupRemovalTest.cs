using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class aGroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupPage();
            app.Groups.SelectGroup(1);
            app.Groups.RemoveGroup();
            app.Groups.RuturnToGroupPage();
        }
    }
}
