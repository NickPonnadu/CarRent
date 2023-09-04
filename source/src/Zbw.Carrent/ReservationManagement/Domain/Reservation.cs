namespace Zbw.Carrent.ReservationManagement.Domain
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalCost { get; set; }

        // Konstruktor und weitere Methoden, falls erforderlich
    }

}
