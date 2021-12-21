using System;
using UnityEngine;
using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;
        private readonly ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            ;
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Debug.Log("ForecastDisplay: ");
            if (_currentPressure > _lastPressure)
            {
                Debug.Log("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Debug.Log("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Debug.Log("Watch out for cooler, rainy weather");
            }
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;

            Display();
        }
    }
}
