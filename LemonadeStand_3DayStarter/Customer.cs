using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variables
        public string name;
        public List<string> customers = new List<string> { "RickyBobby", "JackieMoon", "ChazzMichealMicheals" };


        public Customer()
        {
            name = Names();
        }
        public string Names() //randomly generate customer name from list
        {
            Random rand = new Random();
            string names = customers[rand.Next(customers.Count - 1)];
            return names;
        }
    }
}
