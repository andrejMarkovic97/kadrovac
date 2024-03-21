using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Configurations;
using File = Domain.Entities.File;

namespace Repositories.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Employee> Employees { get; set; } 
    public DbSet<Absence> Absences { get; set; } 
    public DbSet<File> Files { get; set; } 
    public DbSet<Location> Locations { get; set; } 
    public DbSet<Payment> Payments { get; set; } 
    public DbSet<Role> Roles { get; set; } 
    public DbSet<Team> Teams { get; set; } 
    public DbSet<Company> Companies { get; set; } 
    public DbSet<City> Cities { get; set; } 
    public DbSet<Country> Countries { get; set; } 
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new AbsenceConfiguration().Configure(modelBuilder.Entity<Absence>());
        new CompanyConfiguration().Configure(modelBuilder.Entity<Company>());
        new CountryConfiguration().Configure(modelBuilder.Entity<Country>());
        new CityConfiguration().Configure(modelBuilder.Entity<City>());
        new EmployeeConfiguration().Configure(modelBuilder.Entity<Employee>());
        new FileConfiguration().Configure(modelBuilder.Entity<File>());
        new LocationConfiguration().Configure(modelBuilder.Entity<Location>());
        new PaymentConfiguration().Configure(modelBuilder.Entity<Payment>());
        new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
        new TeamConfiguration().Configure(modelBuilder.Entity<Team>());
    }
}