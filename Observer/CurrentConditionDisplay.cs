using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private float temp;
        private float humidity;
        private float pressure;

        public CurrentConditionDisplay(Subject weatherdata)
        {
            weatherdata.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("CurrentCondition：Temperature is {0}; Humidity is {1}; Pressure is {2}.", temp, humidity, pressure);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temp = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
