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
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
           
            GroupData newData = new GroupData("name1");
            newData.Footer = "footer1";
            newData.Header = "header1";

            app.Groups.Modify(1, newData);
        }
    }
}
