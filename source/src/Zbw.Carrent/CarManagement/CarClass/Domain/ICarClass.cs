namespace Zbw.Carrent.CarManagement.CarClass.Domain
{
    public interface ICarClass
    {
        Guid CarClassId { get; set; }
        string ClassName { get; set; }
        decimal DailyRate { get; set; }
        // Weitere Eigenschaften und Methoden, falls benötigt
    }

}
