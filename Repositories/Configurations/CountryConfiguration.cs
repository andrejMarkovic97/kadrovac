using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> entity)
    {
        entity.ToTable("t_countries");
        entity.HasKey(c => c.Id);
        entity.Property(c => c.Id).HasColumnName("country_id").IsRequired();
        entity.Property(c => c.Name).HasColumnName("name").IsRequired().HasMaxLength(50);
        
        entity.HasMany(c => c.Locations)
            .WithOne(c => c.Country)
            .HasForeignKey(c => c.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}