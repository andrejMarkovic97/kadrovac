namespace Domain.Entities;

public class Location(
    Guid id,
    string address,
    Guid cityId,
    City city,
    Guid countryId,
    Country country,
    List<Employee> employees)
{
    public Guid Id { get; set; } = id;
    public string Address { get; set; } = address;
    public Guid CityId { get; set; } = cityId;
    public City City { get; set; } = city;
    public Guid CountryId { get; set; } = countryId;
    public Country Country { get; set; } = country;
    public List<Employee> Employees { get; set; } = employees;
}
