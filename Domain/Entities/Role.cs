namespace Domain.Entities;

public class Role(Guid id, string name, List<Employee> employees)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public List<Employee> Employees { get; set; } = employees;
}