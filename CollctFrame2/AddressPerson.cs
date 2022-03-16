using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollctFrame2
{
    internal class AddressPerson
    {

        public HashSet<GetContact> People;


        public AddressPerson()
        {
            People = new HashSet<GetContact>();
        }


        public GetContact FindContact(string fname)
        {
            GetContact contact = null;

            foreach (var person in People)
            {
                if (person.FirstName.Equals(fname))
                {
                    contact = person;
                    break;
                }
            }
            return contact;
        }


        public bool AddContact(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            GetContact contact = new GetContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);

            GetContact result = FindContact(FirstName);

            if (result == null)
            {
                People.Add(contact);
                return true;
            }
            else
                return false;
        }


        public bool RemoveContact(string name)
        {
            //creation of object for contact
            GetContact c = FindContact(name);

            if (c != null)
            {
                People.Remove(c);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
