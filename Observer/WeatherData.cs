using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherData : Subject
    {
        private float temp;
        private float humidity;
        private float pressure;
        private List<IObserver> Observers;

        /// <summary>
        /// 
        /// </summary>
        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public float GetTemperature()
        {
            return 34.5f;
        }

        public float GetHumidity()
        {
            return 0.67f;
        }

        public float GetPressure()
        {
            return 1.2f;
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMessurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Observers.ForEach(s => s.Update(temp, humidity, pressure));
        }
    }
}
