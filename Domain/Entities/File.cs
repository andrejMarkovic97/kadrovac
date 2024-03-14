using Domain.Enums;

namespace Domain.Entities;

public class File
{
    public Guid Id { get; set; }
    public string Path { get; set; }
    public DateTime DateUploaded { get; set; }
    public string Description { get; set; }
    public FileType FileType { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
