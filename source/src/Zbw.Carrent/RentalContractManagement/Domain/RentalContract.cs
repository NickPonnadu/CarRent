namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public class RentalContract : IRentalContract
    {
        public int RentalContractId { get; set; }
        public int ReservationId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }

        // Konstruktor und weitere Methoden, falls erforderlich
    }
}
