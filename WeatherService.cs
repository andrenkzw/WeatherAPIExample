using System.Collections.Generic;
using System.Threading.Tasks;

public interface WeatherService
{
    Task<ICollection<Weather>> GetWeatherAsync();
}