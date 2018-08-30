using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class aGroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupPage();
            groupHelper.SelectGroup(1);
            groupHelper.RemoveGroup();
            groupHelper.RuturnToGroupPage();
        }
    }
}
