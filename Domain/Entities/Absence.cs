using Domain.Enums;

namespace Domain.Entities;

public class Absence(
    Guid id,
    AbsenceType absenceType,
    DateTime startDate,
    DateTime endDate,
    DateTime dateRequested,
    Guid employeeId,
    Employee employee,
    Guid? approvedById,
    Employee approvedBy,
    Guid? fileId
    )
{
    public Guid Id { get; set; } = id;
    public AbsenceType AbsenceType { get; set; } = absenceType;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public DateTime DateRequested { get; set; } = dateRequested;
    public Guid EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;
    public Guid? ApprovedById { get; set; } = approvedById;
    
    public Employee ApprovedBy { get; set; } = approvedBy;
    public Guid? FileId { get; set; } = fileId;
    public File? File { get; set; } 
}