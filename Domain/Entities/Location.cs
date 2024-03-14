namespace Domain.Entities;

public class Location
{
    public Guid Id { get; set; }
    public string Address { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
    public Guid CountryId { get; set; }
    public Country Country { get; set; }
}
