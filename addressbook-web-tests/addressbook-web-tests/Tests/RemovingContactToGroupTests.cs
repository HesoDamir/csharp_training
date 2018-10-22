using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressbookTests.Model;


namespace WebAddressbookTests.Tests
{
    public class RemovingContactToGroupTests : AuthTestBase
    {
        [Test]
        public void TestRemovingContactFromGroup()
        {
            //группа где предположительно у нас есть контакты
            GroupData group = GroupData.GetAll()[0];
            //получаем список контактов в этой группе
            List<ContactData> oldList = group.GetContacts();

            app.Contacts.RemoveContactFromGroup(oldList[0], group);

            List<ContactData> newList = group.GetContacts();
            Assert.AreEqual(oldList.Count - 1, newList.Count);
        }
    }
}
