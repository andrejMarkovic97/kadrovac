namespace Domain.Entities;

public class Employee(
    Guid id,
    string firstName,
    string lastName,
    string emailAddress,
    string phoneNumber,
    bool isManager,
    string bankAccountNumber,
    int totalVacation,
    int remainingVacation,
    DateTime birthDate,
    DateTime hireDate,
    double wage,
    Guid locationId,
    Location location,
    Guid teamId,
    Team team,
    Guid roleId,
    Role role,
    Guid companyId,
    Company company,
    List<Payment> payments,
    List<Absence> absences,
    List<File> files)
{
    #region Entity Properties

    public Guid Id { get; set; } = id;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string EmailAddress { get; set; } = emailAddress;
    public string PhoneNumber { get; set; } = phoneNumber;
    public bool IsManager { get; set; } = isManager;
    public string BankAccountNumber { get; set; } = bankAccountNumber;
    public int TotalVacation { get; set; } = totalVacation;
    public int RemainingVacation { get; set; } = remainingVacation;
    public DateTime BirthDate { get; set; } = birthDate;
    public DateTime HireDate { get; set; } = hireDate;
    public double Wage { get; set; } = wage;

    #endregion

    #region Navigational properties

    public Guid LocationId { get; set; } = locationId;
    public Location Location { get; set; } = location;
    public Guid TeamId { get; set; } = teamId;
    public Team Team { get; set; } = team;
    public Guid RoleId { get; set; } = roleId;
    public Role Role { get; set; } = role;

    public Guid CompanyId { get; set; } = companyId;

    public Company Company { get; set; } = company;
    public List<Payment> Payments { get; set; } = payments;
    public List<Absence> Absences { get; set; } = absences;
    public List<File> Files { get; set; } = files;

    #endregion
}