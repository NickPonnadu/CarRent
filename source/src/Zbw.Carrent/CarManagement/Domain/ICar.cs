using System.Formats.Asn1;
using Zbw.Carrent.ReservationManagement.Domain;

namespace Zbw.Carrent.CarManagement.Domain
{
    public interface ICar
    {
        Guid CarId { get; set; }
        string Brand { get; set; }
        string Type { get; set; }
        int CarClassId { get; set; }
        CarClass.Domain.CarClass CarClass { get; set; }
        ICollection<Reservation> Reservations { get; set; }
        // Weitere Eigenschaften und Methoden, falls benötigt
    }
}
