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

        //method

        public CupsUsed() // Calculation for cups used for pitcher during runtime
        {
            cupsLeftInPitcher = Pour();

        }

        public int Pour()
        {
         startingAmount = 12;
        while (startingAmount > 0)
            {
                int cupsInPitcher = startingAmount - 1;
                return cupsLeftInPitcher;

            }
        }
}
