using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.Model
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string name;
        private string lastName = "";

        public ContactData(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name && LastName == other.LastName;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + LastName.GetHashCode();
        }
        public override string ToString()
        {
            return "name&lastName = " + Name + " " + LastName;
        }
        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            if (LastName.CompareTo(other.LastName) == 0)
            {
                return Name.CompareTo(other.Name);
            }
            else
            {
                return LastName.CompareTo(other.LastName);
            }
        }
    }
}
