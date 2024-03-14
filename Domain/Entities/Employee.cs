namespace Domain.Entities;

public class Employee
{
    #region Entity Properties

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public bool IsManager { get; set; }
    public string BankAccountNumber { get; set; }
    public int TotalVacation { get; set; }
    public int RemainingVacation { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }
    public double Wage { get; set; }

    #endregion
    #region Navigational properties
    public Guid LocationId { get; set; }
    public Location Location { get; set; }
    public Guid TeamId { get; set; }
    public Team Team { get; set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
    public List<Payment> Payments { get; set; }
    public List<Absence> Absences { get; set; }
    public List<File> Files { get; set; }
    #endregion
}
