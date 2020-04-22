using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Lemon : Item
    {
        // member variables (HAS A)
        public double ten;
        public double twentyfive;
        public double fifty;
        public double total;


        // constructor (SPAWNER)
        public Lemon()
        {
            ten = Ten();
            twentyfive = TwentyFive();
            fifty = Fifty();

        }

        // member methods (CAN DO)

        public double Ten()  //cost for 10 lemons 
        {
            price = .10;
            amount = 10;
            total = price * amount;
            return total;

        }
        public double TwentyFive() // cost for 25 lemons
        {
            price = .10;
           amount = 25;
            total = price * amount;
            return total;

        }
        public double Fifty()  // cost for 50 lemons 
        {
            price = .10;
            amount = 50;
            total = price * amount;
            return total;
        }


    }
}
