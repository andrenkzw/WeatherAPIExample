using System.Collections.Generic;
using System.Threading.Tasks;

public class CityListReader : CityService
{
    public async Task<ICollection<City>> ReadCityListAsync()
    {
        await Task.Delay(1000);
        return new List<City>()
        {
            new City("Sao Paulo", "Brazil"),
            new City("Rio de Janeiro", "Brazil"),
            new City("Salvador", "Brazil"),
        };
    }
}