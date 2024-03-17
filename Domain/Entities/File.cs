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
    List<Absence> absences,
    List<Payment> payments)
{
    public Guid Id { get; set; } = id;
    public string Path { get; set; } = path;
    public DateTime DateUploaded { get; set; } = dateUploaded;
    public string Description { get; set; } = description;
    public FileType FileType { get; set; } = fileType;
    public Guid EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;

    public List<Absence> Absences { get; set; } = absences;
    public List<Payment> Payments { get; set; } = payments;
}
