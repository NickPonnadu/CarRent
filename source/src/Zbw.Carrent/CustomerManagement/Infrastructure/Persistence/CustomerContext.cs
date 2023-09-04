namespace Zbw.Carrent.CustomerManagement.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;

    using Zbw.Carrent.CustomerManagement.Domain;

    public class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //// Configure relationships and entity mappings here
            //modelBuilder.Entity<Customer>()
            //    .HasMany(c => c.Reservations)
            //    .WithOne(r => r.Customer)
            //    .HasForeignKey(r => r.CustomerId);
            //modelBuilder.Entity<Car>()
            //    .HasOne(c => c.CarClass)
            //    .WithMany(cc => cc.Cars)
            //    .HasForeignKey(c => c.ClassId);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; }
    }
}
