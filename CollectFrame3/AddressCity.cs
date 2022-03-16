using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectFrame3
{
    internal class AddressCity
    {
        public HashSet<GetConect> People;
        public AddressCity()
        {
            People = new HashSet<GetConect>();
        }

       
        public GetConect FindContact(string fname)
        {
            GetConect contact = null;
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
             GetConect contact = new GetConect(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            GetConect result = FindContact(FirstName);
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
            GetConect c = FindContact(name);

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
