using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectFrame3
{
    internal class PersonAddress
    {
        public Dictionary<string, HashSet<GetConect>> Binder = new Dictionary<string, HashSet<GetConect>>();
        //creates a list 
        public List<GetConect> City = new List<GetConect>();
        //create a dictionary to store details of city
        public Dictionary<string, List<GetConect>> CityDictionary = new Dictionary<string, List<GetConect>>();

        
        public HashSet<GetConect> AddAddrBook(string key, HashSet<GetConect> set)
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

       
        public List<GetConect> SortingCity(string cityname)
        {
            //traversing in binder class
            foreach (var key in Binder.Keys)
            {
                //traversing for a contact by creating an object c 
                foreach (GetConect c in Binder[key])
                {
                    if (c.City == cityname)
                        City.Add(c);
                }
            }
            return City;
        }

        public List<GetConect> SearchContactsByCity(string city)
        {
            CityDictionary[city] = SortingCity(city);
            return CityDictionary[city];
        }
    }
}
