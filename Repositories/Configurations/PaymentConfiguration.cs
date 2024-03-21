using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Domain.Entities.File;

namespace Repositories.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("t_payments");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("payment_id").IsRequired();
        builder.Property(p => p.EmployeeId).HasColumnName("employee_id").IsRequired();
        builder.Property(p => p.Amount).HasColumnName("amount").IsRequired();
        builder.Property(p => p.Date).HasColumnName("date").IsRequired();
        builder.Property(p => p.FileId).HasColumnName("file_id");
        
        builder.HasOne(p => p.Employee)
            .WithMany(e => e.Payments)
            .HasForeignKey(p => p.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.File)
            .WithOne(f => f.Payment)
            .HasForeignKey<File>(f => f.PaymentId);
    }
}