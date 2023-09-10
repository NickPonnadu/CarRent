using Zbw.Carrent.CarManagement.Domain;
using Zbw.Carrent.RentalContractManagement.Domain;

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

        public Car Car { get; set; }

        public RentalContract RentalContract { get; set; }
        // Konstruktor und weitere Methoden, falls erforderlich
    }

}
