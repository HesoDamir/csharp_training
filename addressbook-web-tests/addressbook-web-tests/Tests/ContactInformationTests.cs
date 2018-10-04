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
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
            ContactData fromFrom = app.Contacts.GetContactInformationFromEditFrom(0);
            ContactData fromProperty = app.Contacts.GetContactInformationFromProperty(0);

            Assert.AreEqual(fromTable, fromFrom);
            Assert.AreEqual(fromTable.Address, fromFrom.Address);
            Assert.AreEqual(fromTable.AllEmails, fromFrom.AllEmails);
            Assert.AreEqual(fromTable.AllPhones, fromFrom.AllPhones);


        }
    }
}
