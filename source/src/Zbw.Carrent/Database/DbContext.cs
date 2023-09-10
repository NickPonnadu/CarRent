using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.CarManagement.CarClass.Domain;
using Zbw.Carrent.CarManagement.Domain;
using Zbw.Carrent.CustomerManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Domain;
using Zbw.Carrent.ReservationManagement.Domain;

public class CarRentalDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<RentalContract> RentalContracts { get; set; }
    public DbSet<CarClass> CarClasses { get; set; }

    public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Hier können Sie die Konfiguration der Entitäten und Beziehungen festlegen,
        // einschließlich der Festlegung von Schlüsseln und Beziehungen.

        modelBuilder.Entity<Customer>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Car>()
            .HasKey(c => c.CarId);

        modelBuilder.Entity<Reservation>()
            .HasKey(r => r.ReservationId);

        modelBuilder.Entity<RentalContract>()
            .HasKey(rc => rc.RentalContractId);

        modelBuilder.Entity<CarClass>()
            .HasKey(cc => cc.CarClassId);

        // Hier können Sie Beziehungen zwischen den Entitäten konfigurieren, z.B.:

        modelBuilder.Entity<Car>()
            .HasOne(c => c.CarClass)
            .WithMany(cc => cc.Cars)
            .HasForeignKey(c => c.CarClassId);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Car)
            .WithMany(c => c.Reservations)
            .HasForeignKey(r => r.CarId);

        modelBuilder.Entity<RentalContract>()
            .HasOne(rc => rc.Reservation)
            .WithOne(r => r.RentalContract)
            .HasForeignKey<RentalContract>(rc => rc.ReservationId);
    }
}