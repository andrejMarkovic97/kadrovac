namespace Domain.Entities;

public class Company(Guid id, string name, List<Employee> employees, List<Team> teams)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public List<Employee> Employees { get; set; } = employees;
    public List<Team> Teams { get; set; } = teams;
}
