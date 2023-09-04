using System.ComponentModel.DataAnnotations;
using Zbw.Carrent.CarManagement.Domain;

namespace Zbw.Carrent.CarManagement.CarClass.Domain
{

    public class CarClass : ICarClass
    {
        public Guid CarClassId { get; set; }
        public string ClassName { get; set; }
        public decimal DailyRate { get; set; }

        public List<Car> Cars { get; set; }
        // Konstruktor und weitere Methoden, falls erforderlich
    }
}
