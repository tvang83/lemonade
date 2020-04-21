using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Item
    {
        // member variables (HAS A) - 
        public string name;
        public int price;
        public int amount;

        // constructor (SPAWNER)
        public Item(string name, int price, int amount) //default variables for all shop items
        {
            this.name = name;
            this.price = price;
            this.amount = amount;

        }

        // member methods (CAN DO)


    }
}
