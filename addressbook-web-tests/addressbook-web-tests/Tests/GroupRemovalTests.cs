using NUnit.Framework;
using System.Collections.Generic;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class GroupRemovalTests : GroupTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            GroupData group = new GroupData("name");
            group.Footer = "footer";
            group.Header = "header";

            List<GroupData> oldGroups = GroupData.GetAll();
            GroupData toBeRemoved = oldGroups[0];
            app.Navigator.GoToGroupPage();
            if (!app.Groups.CheckBoxOfGroupIsPresent())
            {
                app.Groups.Create(group);
            }

            app.Groups.Remove(toBeRemoved);

            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());

            List<GroupData> newGroups = GroupData.GetAll(); 
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData newGroup in newGroups)
            {
                Assert.AreNotEqual(newGroup.Id, toBeRemoved.Id);
            }
        }
    }
}
