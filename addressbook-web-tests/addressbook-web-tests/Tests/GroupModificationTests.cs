using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests.Model;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class GroupModificationTests : GroupTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData group = new GroupData("name");
            group.Footer = "footer";
            group.Header = "header";

            GroupData newData = new GroupData("name1");
            newData.Footer = "footer1";
            newData.Header = "header1";

            List<GroupData> oldGroups = GroupData.GetAll();
            GroupData oldData = oldGroups[0];

            app.Navigator.GoToGroupPage();
            if (!app.Groups.CheckBoxOfGroupIsPresent())
            {
                app.Groups.Create(group);
            }

            app.Groups.Modify(newData, oldData);

            List<GroupData> newGroups = GroupData.GetAll();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
