namespace Domain.Entities;

public class Payment(Guid id, double amount, DateTime date, Guid employeeId, Employee employee)
{
    public Guid Id { get; set; } = id;
    public double Amount { get; set; } = amount;
    public DateTime Date { get; set; } = date;
    public Guid EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;
    
    public Guid? FileId { get; set; }
    
    public File? File { get; set; }
}