using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class aGroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
        }
    }
}
