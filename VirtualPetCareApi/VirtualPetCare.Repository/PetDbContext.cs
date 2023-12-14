using Microsoft.EntityFrameworkCore;
using VirtualPetCare.Core.Models;

namespace VirtualPetCare.Repository;

public class PetDbContext : DbContext
{
    public PetDbContext()
    {
            
    }
    public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
    {
          
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=petdb;Username=postgres;Password=postgres");
        }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<HealthCondition> HealthConditions { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Activity> Activities { get; set; }
}
