namespace Zbw.Carrent.ReservationManagement.Domain
{

    public interface IReservation
    {
        int ReservationId { get; set; }
        int CustomerId { get; set; }
        int CarId { get; set; }
        DateTime ReservationDate { get; set; }
        int NumberOfDays { get; set; }
        decimal TotalCost { get; set; }
        // Weitere Eigenschaften und Methoden, falls benötigt
    }

}
