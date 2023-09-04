namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public interface IRentalContract
    {
        int RentalContractId { get; set; }
        int ReservationId { get; set; }
        DateTime PickupDate { get; set; }
        DateTime ReturnDate { get; set; }
        decimal TotalCost { get; set; }
        // Weitere Eigenschaften und Methoden, falls benötigt
    }
    
}
