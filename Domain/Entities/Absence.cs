using Domain.Enums;

namespace Domain.Entities;

public class Absence
{
    public Guid Id { get; set; }
    public AbsenceType Type { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public DateTime DateRequested { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public Guid? ApprovedById { get; set; }
    public Employee ApprovedBy { get; set; }
    public Guid? FileId { get; set; }
    public File File { get; set; }
}