using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class SugarCube : Item
    {
        // member variables (HAS A)

        public double oneHundred;
        public double twoHundred;
        public double fiveHundred;
        public double total;


        // constructor (SPAWNER)
        public SugarCube()
        {
            name = "sugar cube";
            oneHundred = OneHundred();
            twoHundred = TwoHundred();
            fiveHundred = FiveHundred();
           
        }

        // member methods (CAN DO)
        public double OneHundred()
        {
            price = .014;
            amount = 100;
            total = price * amount;
            return total;

        }
        public double TwoHundred()
        {
            price = .012;
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
