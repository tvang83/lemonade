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

        // constructor (SPAWNER)
        public SugarCube()
        {
            name = "sugar cube";
        }

        // member methods (CAN DO)
        public OneHundred(double price, int amount)
        {
            this.price = .014;
            this.amount = 100;
            total = price * amount;
            return total;

        }
        public TwoHundred(double price, int amount)
        {
            this.price = .012;
            this.amount = 200;
            total = price * amount;
            return total;

        }
        public FiveHundred(double price, int amount)
        {
            this.price = .01;
            this.amount = 500;
            total = price * amount;
            return total;
        }
    }
}
