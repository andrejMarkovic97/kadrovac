using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("t_roles");
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id).HasColumnName("role_id").IsRequired();
        builder.Property(r => r.Name).HasColumnName("name").IsRequired().HasMaxLength(50);
        
        builder.HasMany(r => r.Employees)
            .WithOne(e => e.Role)
            .HasForeignKey(e => e.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}