using Microsoft.EntityFrameworkCore;

namespace EntityExample
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<BankAccount> BankAccounts => Set<BankAccount>();

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDataBase.db");
        }
    }

}