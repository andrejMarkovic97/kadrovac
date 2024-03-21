using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Domain.Entities.File;

namespace Repositories.Configurations;

public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("t_files");
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).HasColumnName("file_id").IsRequired();
        builder.Property(f => f.Path).HasColumnName("path").IsRequired().HasMaxLength(255);
        builder.Property(f => f.Description).HasColumnName("description").IsRequired().HasMaxLength(255);
        builder.Property(f => f.FileType).HasColumnName("file_type").IsRequired();
        builder.Property(f => f.EmployeeId).HasColumnName("employee_id").IsRequired();
        builder.Property(f => f.DateUploaded).HasColumnName("date_uploaded").IsRequired();

        builder.HasOne(f => f.Employee)
            .WithMany(e => e.Files)
            .HasForeignKey(f => f.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(f => f.Absence)
            .WithOne(a => a.File)
            .HasForeignKey<File>(f => f.AbsenceId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(f => f.Payment)
            .WithOne(p => p.File)
            .HasForeignKey<Payment>(p => p.FileId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}