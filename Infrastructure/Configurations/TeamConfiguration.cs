using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("t_teams");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).HasColumnName("team_id").IsRequired();
        builder.Property(t => t.Name).HasColumnName("name").IsRequired().HasMaxLength(50);
        builder.Property(t => t.CompanyId).HasColumnName("company_id").IsRequired();
        
        builder.HasOne(t => t.Company)
            .WithMany(c => c.Teams)
            .HasForeignKey(t => t.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}