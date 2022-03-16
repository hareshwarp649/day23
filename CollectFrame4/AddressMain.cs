using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectFrame4
{
    internal class AddressMain
    {
        public HashSet<SetContact> People;

      
        public AddressMain()
        {
            People = new HashSet<SetContact>();
        }

     
        public SetContact FindContact(string fname)
        {
            SetContact contact = null;
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
            SetContact contact = new SetContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
           
            SetContact result = FindContact(FirstName);
           
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
           
           SetContact c = FindContact(name);
           
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
