using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Configurations;
using File = Domain.Entities.File;

namespace Repositories.DbContext;

public class AppDbContext(
    DbContextOptions<AppDbContext> options,
    DbSet<Employee> employees,
    DbSet<Absence> absences,
    DbSet<File> files,
    DbSet<Location> locations,
    DbSet<Payment> payments,
    DbSet<Role> roles,
    DbSet<Team> teams,
    DbSet<Company> companies,
    DbSet<City> cities,
    DbSet<Country> countries)
    : Microsoft.EntityFrameworkCore.DbContext(options)
{
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

    public DbSet<Employee> Employees { get; set; } = employees;
    public DbSet<Absence> Absences { get; set; } = absences;
    public DbSet<File> Files { get; set; } = files;
    public DbSet<Location> Locations { get; set; } = locations;
    public DbSet<Payment> Payments { get; set; } = payments;
    public DbSet<Role> Roles { get; set; } = roles;
    public DbSet<Team> Teams { get; set; } = teams;
    public DbSet<Company> Companies { get; set; } = companies;
    public DbSet<City> Cities { get; set; } = cities;
    public DbSet<Country> Countries { get; set; } = countries;
}