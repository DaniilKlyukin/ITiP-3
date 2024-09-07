using Microsoft.EntityFrameworkCore;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(string path)
    {
        Path = path;
        Database.EnsureCreated(); // Если БД нет, то она будет создана
    }

    public DbSet<Person> Persons => Set<Person>();
    public string Path { get; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Path}");
    }
}