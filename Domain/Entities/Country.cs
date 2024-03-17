namespace Domain.Entities;

public class Country(Guid id, string name, List<Location> locations)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public List<Location> Locations { get; set; } = locations;
}
