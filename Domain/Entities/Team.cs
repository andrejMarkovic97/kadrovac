namespace Domain.Entities;

public class Team(Guid id, string name, Guid companyId, Company company, List<Employee> employees)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public Guid CompanyId { get; set; } = companyId;
    public Company Company { get; set; } = company;
    public List<Employee> Employees { get; set; } = employees;
}