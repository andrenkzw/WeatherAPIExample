using System.Collections.Generic;
using System.Threading.Tasks;

public interface CityService
{
    Task<ICollection<City>> ReadCityListAsync();
}