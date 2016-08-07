using Observer;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherData data = new WeatherData();
            CurrentConditionDisplay condition = new CurrentConditionDisplay(data);
            data.SetMessurements(34, 20, 1.5f);

            Console.ReadLine();
        }
    }
}
