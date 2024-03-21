using Domain.Enums;

namespace Domain.Entities;

public class File(
    Guid id,
    string path,
    DateTime dateUploaded,
    string description,
    FileType fileType,
    Guid employeeId,
    Employee employee,
    Guid absenceId,
    Absence absence,
    Guid paymentId,
    Payment payment)
{
    public Guid Id { get; set; } = id;
    public string Path { get; set; } = path;
    public DateTime DateUploaded { get; set; } = dateUploaded;
    public string Description { get; set; } = description;
    public FileType FileType { get; set; } = fileType;
    public Guid EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;

    public Guid AbsenceId { get; set; } = absenceId;
    public Absence Absence { get; set; } = absence;

    public Guid PaymentId { get; set; } = paymentId;

    public Payment Payment { get; set; } = payment;
}
