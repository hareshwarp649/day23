using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc7COllectFrameAddBook
{
    internal class AddBookService
    {

        public Dictionary<string, HashSet<SetContact>>pairs = new Dictionary<string, HashSet<SetContact>>();
        //creates a list 
        public List<SetContact> City = new List<SetContact>();
       

        public HashSet<SetContact> AddAddrBook(string key, HashSet<SetContact> set)
        {
            if (this.pairs.ContainsKey(key))
            {
                Console.WriteLine("Address book already exists");
                return pairs[key];
            }
            else
            {
                Console.WriteLine("New address book created");
                pairs.Add(key, set);
                return pairs[key];
            }
        }
    }
}
