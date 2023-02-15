using System;
using System.Threading.Tasks;

namespace WeatherAPIExample;
class Program
{
    static async Task Main(string[] args)
    {
        WeatherService ws = new WeatherRepository();
        CityService cs = new CityListReader();
        var task1 = Task.Run(ws.GetWeatherAsync);
        var task2 = Task.Run(cs.ReadCityListAsync);
        await Task.WhenAll(task1, task2);
        Console.WriteLine("TEMPO");
        foreach (var weather in task1.Result)
        {
            Console.WriteLine(weather);
            Console.WriteLine();
        }
        Console.WriteLine("LISTA DE CIDADES");
        foreach (var city in task2.Result)
        {
            Console.WriteLine(city);
        }
    }
}
