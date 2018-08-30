using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            groupHelper.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            GroupData group = new GroupData("name");
            group.Footer = "footer";
            group.Header = "header";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            groupHelper.ReturnToGroupsPage();
            Logout();
        }

    }

}
