using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        //member variable 
        public int startingAmount;
        public int cupsLeftInPitcher;

        //constructor 

        public Pitcher() // Calculation for cups used for pitcher during runtime
        {
            cupsLeftInPitcher = Pour();

        }
        //method
        public int Pour() // when customer purchases a cup
        {
         startingAmount = 12;
        while (cupsLeftInPitcher > 0)
            {
                cupsLeftInPitcher = startingAmount - 1;
                return cupsLeftInPitcher;
            }
        }
}
