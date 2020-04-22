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
        public double twenty;
        public double oneHundred;
        public double twoHundred;
        public double total;


        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
            twenty = Twenty();
            oneHundred = OneHundred();
            twoHundred = TwoHundred();

        }

        // member methods (CAN DO)

        public double Twenty()
        {
            price = .013;
            amount = 20;
            total = price * amount;
            return total;

        }
        public double OneHundred()
        {
            price = .016;
            amount = 100;
            total = price * amount;
            return total;

        }
        public double TwoHundred()
        {
            price = .01;
            amount = 200;
            total = price * amount;
            return total;
        }
    }
}
