using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Cup : Item
    {
        // member variables (HAS A)
        public double total;


        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
        }

        // member methods (CAN DO)

        public Twenty(double price, int amount)
        {
            this.price = .013;
            this.amount = 20;
            total = price * amount;
            return total;

        }
        public OneHundred(double price, int amount)
        {
            this.price = .016;
            this.amount = 100;
            total = price * amount;
            return total;

        }
        public TwoHundred(double price, int amount)
        {
            this.price = .01;
            this.amount = 200;
            total = price * amount;
            return total;
        }
    }
}
