using Microsoft.EntityFrameworkCore;

namespace AnimalInformationSystem;

public class AnimalContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=animals.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>().ToTable("Animals");
    }
}