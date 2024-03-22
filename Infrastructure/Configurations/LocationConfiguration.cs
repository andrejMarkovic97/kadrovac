using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> entity)
    {
        entity.ToTable("t_locations");
        entity.HasKey(l => l.Id);
        entity.Property(l => l.Address).HasColumnName("address").IsRequired();
        entity.Property(l => l.Id).HasColumnName("location_id").IsRequired();
        entity.Property(l => l.CityId).HasColumnName("city_id").IsRequired();
        entity.Property(l => l.CountryId).HasColumnName("country_id").IsRequired();

        entity.HasOne(l => l.City)
            .WithMany(c => c.Locations)
            .HasForeignKey(l => l.CityId)
            .OnDelete(DeleteBehavior.Restrict);

        entity.HasOne(l => l.Country)
            .WithMany(c => c.Locations)
            .HasForeignKey(l => l.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}