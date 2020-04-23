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
        public List<string> weatherCondition = new List<string> { "Hazy", "Cloudy", "Rainy", "Sunny", "Overcast"};


    //constructor
    public Weather()
        {
            condition = DailyCondition();
            temperature = Temperature();

        }


        //methods 
        public int Temperature() //generate a random number between 50-100 for temperature
        {
            Random rand = new Random();
            int temperature = rand.Next(51, 101);
            return temperature;
        }

        public string DailyCondition()  //random daily conditions 
        {

            Random rand = new Random();
            string randCondition = weatherCondition[rand.Next(weatherCondition.Count-1)];
            return randCondition;

        }



    }
}
