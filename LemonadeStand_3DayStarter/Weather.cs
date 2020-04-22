using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables 
        public int temperature;
        public string condition;
        public List<Customer> customers;

        //constructor
        public Weather()
        {

        }


        //methods 
        public int Temperature() //generate a random number between 50-100 for temperature
        {
            Random rand = new Random();
            int temperature = rand.Next(51, 101);
            return temperature;
        }

        public string Condition()
        {
            condition = new List<string> { "Hazy", "Cloudy", "Rainy", "Sunny", "Overcast"};

            Random rand = new Random();
            string randCondition = rand.Next(condition.Count);
            return randCondition;

        }



    }
}
