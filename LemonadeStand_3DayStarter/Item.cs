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
        public double price;
        public int amount;

        // constructor (SPAWNER)
        public Item() //default variables for all shop items
        {


        }

        // member methods (CAN DO)
        public void AllItems()  //no usage, just a placeholder for now
        {

        }

    }
}
