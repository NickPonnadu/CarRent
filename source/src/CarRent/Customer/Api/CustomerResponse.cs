namespace CarRent.Customer.Api
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public int CustomerNr { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
    }
}
