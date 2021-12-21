using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeatherStation.Observers;
using WeatherStation.Subjects;

public class Test02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
        TestObserverDotNet();
    }

    void Test()
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4d);
        weatherData.SetMeasurements(82, 70, 29.2d);
        weatherData.SetMeasurements(78, 90, 29.2d);
    }
    /// <summary>
    /// Observer Pattern by DotNet
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern"/>
    /// </summary>
    void TestObserverDotNet()
    {
        BaggageHandler provider = new BaggageHandler();
        ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
        ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityExit");

        provider.BaggageStatus(712, "Detroit", 3);
        observer1.Subscribe(provider);
        provider.BaggageStatus(712, "Kalamazoo", 3);
        provider.BaggageStatus(400, "New York-Kennedy", 1);
        provider.BaggageStatus(712, "Detroit", 3);
        observer2.Subscribe(provider);
        provider.BaggageStatus(511, "San Francisco", 2);
        provider.BaggageStatus(712);
        observer2.Unsubscribe();
        provider.BaggageStatus(400);
        provider.LastBaggageClaimed();
    }
}
