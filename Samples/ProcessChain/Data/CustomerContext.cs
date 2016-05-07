using FP.Spartakiade2016.ProcessChain.Data.Models;
using Microsoft.Data.Entity;

namespace FP.Spartakiade2016.ProcessChain.Data
{
    internal class CustomerContext : DbContext
    {
        private string _connectionstring = "User ID=spartakiade;Password=SportF3;Host=postgresql;Port=5432;Database=spartakiade;Pooling=true";
        public CustomerContext()
        {
            
        }

        public CustomerContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<Reversal> Reversals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(b => b.Name).IsRequired();

            modelBuilder.Entity<Address>();

            modelBuilder.Entity<Bill>();

            modelBuilder.Entity<Position>();

            modelBuilder.Entity<Reversal>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionstring);
        }
    }
}
