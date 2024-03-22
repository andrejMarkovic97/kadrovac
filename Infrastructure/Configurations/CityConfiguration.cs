using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> entity)
    {
        entity.ToTable("t_cities");
        entity.HasKey(c => c.Id);
        entity.Property(c => c.Id).HasColumnName("city_id").IsRequired();
        entity.Property(c => c.Name).HasColumnName("name").IsRequired().HasMaxLength(50);
        
        entity.HasMany(c => c.Locations)
            .WithOne(l => l.City)
            .HasForeignKey(l => l.CityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}