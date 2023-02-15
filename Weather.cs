using System;
using System.ComponentModel;

public enum WeatherType
{
    [Description("Ensolarado")]
    Sunny,
    [Description("Nublado")]
    Cloudy,
    [Description("Chovendo")]
    Rainy,
    [Description("Nevando")]
    Snowy,
}

public class Weather
{
    City City { get; init; }
    DateTime Day { get; init; }
    WeatherType Type { get; init; }
    double MinTemperature { get; init; }
    double MaxTemperature { get; init; }

    public Weather(City city, DateTime day, WeatherType type, double MinTemperature, double MaxTemperature)
    {
        this.City = city;
        this.Day = day;
        this.Type = type;
        this.MinTemperature = MinTemperature;
        this.MaxTemperature = MaxTemperature;
    }

    public override string ToString()
    {
        return $"Cidade: {City}\nDia: {Day.ToShortDateString()}\nDescrição: {Type}\nTemperatura: {MinTemperature} ~ {MaxTemperature} C";
    }
}