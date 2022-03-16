using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectFrame4
{
    internal class CountAddress
    {
        public Dictionary<string, HashSet<SetContact>> Binder = new Dictionary<string, HashSet<SetContact>>();
        //dictinary to store city
        public Dictionary<string, List<SetContact>> CityDictionary = new Dictionary<string, List<SetContact>>();

      
        public HashSet<SetContact> AddAddrBook(string key, HashSet<SetContact> set)
        {
            if (this.Binder.ContainsKey(key))
            {
                Console.WriteLine("Address book already exists");
                return Binder[key];
            }
            else
            {
                Console.WriteLine("New address book created");
                Binder.Add(key, set);
                return Binder[key];
            }
        }

       
        public List<string> DistinctCities()
        {
            //creating a list
            List<string> City = new List<string>();
            //traversing 
            foreach (var key in Binder.Keys)
            {
                foreach (SetContact c in Binder[key])
                {
                    if (City.Contains(c.City))
                        break;
                    else
                        City.Add(c.City);
                }
            }
            return City;
        }

      
        public void CreateDictionary()
        {
            //creates a list
            List<string> City1 = DistinctCities();
            //traverse through city
            foreach (string city in City1)
            {
                //creates a list
                List<SetContact> CityContact = new List<SetContact>();
                foreach (var key in Binder.Keys)
                {
                   
                    foreach (SetContact c in Binder[key])
                    {
                        if (c.City == city)
                            CityContact.Add(c);
                    }
                }
               
                if (this.CityDictionary.ContainsKey(city))
                    CityDictionary[city] = CityContact;
                else
                    CityDictionary.Add(city, CityContact);
            }
        }

    }
}
