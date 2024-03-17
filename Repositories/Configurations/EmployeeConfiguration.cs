using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    
    public void Configure(EntityTypeBuilder<Employee> entity)
    {
        entity.ToTable("t_employees");
        entity.HasKey(e => e.Id);
        entity.HasIndex(e=> e.EmailAddress).IsUnique();
        
        entity.Property(e => e.Id).HasColumnName("employee_id").IsRequired();
        entity.Property(e => e.FirstName).HasColumnName("first_name").IsRequired().HasMaxLength(50);
        entity.Property(e => e.LastName).HasColumnName("last_name").IsRequired().HasMaxLength(50);
        entity.Property(e => e.EmailAddress).HasColumnName("email_address").IsRequired().HasMaxLength(100);
        entity.Property(e => e.PhoneNumber).HasColumnName("phone_number").IsRequired().HasMaxLength(20);
        entity.Property(e => e.BirthDate).HasColumnName("birth_date").IsRequired();
        entity.Property(e => e.HireDate).HasColumnName("hire_date").IsRequired();
        entity.Property(e => e.Wage).HasColumnName("wage").IsRequired();
        entity.Property(e => e.BankAccountNumber).HasColumnName("bank_account_number").IsRequired().HasMaxLength(50);
        entity.Property(e => e.TotalVacation).HasColumnName("total_vacation").IsRequired();
        entity.Property(e => e.RemainingVacation).HasColumnName("remaining_vacation").IsRequired();
        entity.Property(e => e.IsManager).HasColumnName("is_manager").IsRequired();
        entity.Property(e => e.LocationId).HasColumnName("location_id").IsRequired();
        entity.Property(e => e.TeamId).HasColumnName("team_id").IsRequired();

        entity.HasOne(e => e.Location)
            .WithMany(l => l.Employees)
            .HasForeignKey(e => e.LocationId)
            .OnDelete(DeleteBehavior.Restrict);
        
        entity.HasOne(e => e.Team)
            .WithMany(t => t.Employees)
            .HasForeignKey(e => e.TeamId)
            .OnDelete(DeleteBehavior.Restrict);
        
        entity.HasOne(e => e.Role)
            .WithMany(r => r.Employees)
            .HasForeignKey(e => e.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
        
        entity.HasMany(e => e.Payments)
            .WithOne(p => p.Employee)
            .HasForeignKey(p => p.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
        
        entity.HasMany(e => e.Absences)
            .WithOne(a => a.Employee)
            .HasForeignKey(a => a.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
        
       entity.HasMany(e => e.Files)
            .WithOne(f => f.Employee)
            .HasForeignKey(f => f.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
       
       entity.HasOne(e => e.Company)
           .WithMany(c => c.Employees)
           .HasForeignKey(e => e.CompanyId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}