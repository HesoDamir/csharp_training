using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("name");
            group.Footer = "footer";
            group.Header = "header";

            app.Groups.Create(group);
            app.Navigator.Logout();
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Footer = "";
            group.Header = "";

            app.Groups.Create(group);
            app.Navigator.Logout();
        }

    }

}
