using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Domain.Entities.File;

namespace Repositories.Configurations;

public class AbsenceConfiguration : IEntityTypeConfiguration<Absence>
{
    public void Configure(EntityTypeBuilder<Absence> builder)
    {
        builder.ToTable("t_absences");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("absence_id").IsRequired();
        builder.Property(a => a.EmployeeId).HasColumnName("employee_id").IsRequired();
        builder.Property(a => a.StartDate).HasColumnName("start_date").IsRequired();
        builder.Property(a => a.EndDate).HasColumnName("end_date").IsRequired();
        builder.Property(a => a.AbsenceType).HasColumnName("absence_type").IsRequired();
        builder.Property(a => a.DateRequested).HasColumnName("date_requested").IsRequired();
        builder.Property(a => a.ApprovedById).HasColumnName("approved_by_id");
        builder.Property(a => a.FileId).HasColumnName("file_id");
        
        builder.HasOne(a => a.Employee)
            .WithMany(e => e.Absences)
            .HasForeignKey(a => a.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(a => a.File)
            .WithOne(f => f.Absence)
            .HasForeignKey<File>(f => f.AbsenceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}