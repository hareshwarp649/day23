using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollctFrame2
{
    internal class SearchPersonAddress
    {
        public Dictionary<string, HashSet<GetContact>> Binder = new Dictionary<string, HashSet<GetContact>>();
        //creates a list 
        public List<GetContact> City = new List<GetContact>();
        //create a dictionary to store details of city
        public Dictionary<string ,List<GetContact>> CityDictionary = new Dictionary<string, List<GetContact>>();

       
        public HashSet<GetContact> AddAddrBook(string key, HashSet<GetContact> set)
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

       
        public List<GetContact> SortingCity(string cityname)
        {
            //traversing in binder class
            foreach (var key in Binder.Keys)
            {
               
                foreach (GetContact c in Binder[key])
                {
                    if (c.City == cityname)
                        City.Add(c);
                }
            }
            return City;
        }

       
        public List<GetContact> SearchContactsByCity(string city)
        {
            CityDictionary[city] = SortingCity(city);
            return CityDictionary[city];
        }
    }
}
