using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class IceCube : Item
    {
        // member variables (HAS A)
        public double oneHundred;
        public double twoHundred;
        public double fiveHundred;
        public double total;

        // constructor (SPAWNER)
        public IceCube()
        {
            name = "ice cube";
            oneHundred = OneHundred();
            twoHundred = TwoHundred();
            fiveHundred = FiveHundred();

        }

        // member methods (CAN DO)

        public double OneHundred()
        {
            price = .03;
            amount = 100;
            total = price * amount;
            return total;

        }
        public double TwoHundred()
        {
            price = .02;
            amount = 200;
            total = price * amount;
            return total;

        }
        public double FiveHundred()
        {
            price = .01;
            amount = 500;
            total = price * amount;
            return total;
        }
    }
}
