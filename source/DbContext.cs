using Microsoft.EntityFrameworkCore;

public class CarRentalDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarClass> CarClasses { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<RentalContract> RentalContracts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Hier konfigurieren Sie die Verbindung zur Datenbank, z.B. eine SQL Server-Verbindung.
        optionsBuilder.UseSqlServer("DeineVerbindungszeichenfolge");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Hier können Sie die Konfiguration der Entitäten und Beziehungen festlegen, z.B. Schlüssel und Fremdschlüssel.
        modelBuilder.Entity<CarClass>()
            .HasMany(cc => cc.Cars)
            .WithOne(c => c.CarClass)
            .HasForeignKey(c => c.CarClassId);

        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Reservations)
            .WithOne(r => r.Customer)
            .HasForeignKey(r => r.CustomerId);

        modelBuilder.Entity<Car>()
            .HasMany(c => c.Reservations)
            .WithOne(r => r.Car)
            .HasForeignKey(r => r.CarId);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.RentalContract)
            .WithOne(rc => rc.Reservation)
            .HasForeignKey<RentalContract>(rc => rc.ReservationId);
    }
}