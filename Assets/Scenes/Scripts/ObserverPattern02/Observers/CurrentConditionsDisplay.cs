using System;
using UnityEngine;
using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
           Debug.Log("CurrentConditionsDisplay:" + _temperature + "F degrees and " + _humidity + "% humidity");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
