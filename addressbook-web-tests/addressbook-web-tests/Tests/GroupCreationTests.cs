using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Groups.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("name");
            group.Footer = "footer";
            group.Header = "header";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
            app.Navigator.Logout();
        }

    }

}
