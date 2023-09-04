using Zbw.Carrent.ReservationManagement.Domain;

namespace Zbw.Carrent.CarManagement.Domain
{
    public class Car :ICar
    {
        
        public Guid CarId { get; set; } // Eindeutige Identifikation des Autos
        public string Brand { get; set; } // Marke des Autos
        public string Type { get; set; } // Typ des Autos
        public int CarClassId { get; set; } // Fremdschlüssel zur Auto-Klasse
        public CarClass.Domain.CarClass CarClass { get; set; } // Navigationseigenschaft zur Auto-Klasse
        // Weitere Eigenschaften des Autos, z.B. Identifikation, Zustand usw.

        public ICollection<Reservation> Reservations { get; set; } // Liste der Reservierungen für dieses Auto

        // Konstruktor und weitere Methoden, falls erforderlich

    }
}
