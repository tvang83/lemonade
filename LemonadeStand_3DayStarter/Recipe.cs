using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //Member variables 
        int amountOfLemons;
        int amountOfSugarCubes;
        int amountOfIceCubes;
        double pricePerCup;

        //constructor 
        public Recipe()
        {
            amountOfLemons = enterAmountOfLemons();
            amountOfSugarCubes = enterAmountOfSugarCubes();
            amountOfIceCubes = enterAmountOfIceCubes();
            pricePerCup = enterPricePerCup();
        }

        //methods 

        public int enterAmountOfLemons()
        {
            Console.WriteLine("How many lemons do you want use per pitcher?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            return amountOfLemons;
        }
        public int enterAmountOfSugarCubes()
        {
            Console.WriteLine("How many sugar cubes do you want use per pitcher?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            return amountOfSugarCubes;

        }
        public int enterAmountOfIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want use per pitcher?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            return amountOfIceCubes;
        }
        public double enterPricePerCup()
        {
            Console.WriteLine("How much do you want to sell a cup of lemonade?");
            pricePerCup = Convert.ToInt32(Console.ReadLine());
            return pricePerCup;
        }
    }
}
