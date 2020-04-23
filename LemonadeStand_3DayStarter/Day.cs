using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {

        //member variables
        public Weather weather;
        public List<Customer> customers;


        //constructors
        public Day()
        {
            weather = new Weather(); //obtains the temperature and conditions from Weather class
            customers = new List<Customer>(); //calls customer class for customer name from list name
        }

        //methods 
        public CallWeather()
        {
        }

    }
}
