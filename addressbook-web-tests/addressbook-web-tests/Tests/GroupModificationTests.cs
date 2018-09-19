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
    public class GroupModificationTests : AuthTestBase
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

            app.Navigator.GoToGroupPage();
            if (!app.Groups.CheckBoxOfGroupIsPresent())
            {
                app.Groups.Create(group);
            }
            app.Groups.Modify(newData, 1);
        }
    }
}
