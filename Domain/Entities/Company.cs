namespace Domain.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
}