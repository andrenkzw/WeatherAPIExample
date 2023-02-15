using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class WeatherRepository : WeatherService
{
    public async Task<ICollection<Weather>> GetWeatherAsync()
    {
        await Task.Delay(3000);
        return new List<Weather>()
        {
            new Weather(new City("Sao Paulo", "Brazil"), DateTime.Today, WeatherType.Rainy, 14, 22),
            new Weather(new City("Rio de Janeiro", "Brazil"), DateTime.Today, WeatherType.Cloudy, 20, 29),
            new Weather(new City("Salvador", "Brazil"), DateTime.Today, WeatherType.Sunny, 21, 32),
        };
    }
}