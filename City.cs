public class City
{
    public string Name { get; init; }
    public string Country { get; init; }

    public City(string name, string country)
    {
        this.Name = name;
        this.Country = country;
    }

    public override string ToString()
    {
        return $"{Name} - {Country}";
    }
}