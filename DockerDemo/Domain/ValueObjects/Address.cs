namespace Domain.ValueObjects
{
    public class Address
    {
        public required string Street { get; set; }
        public required string City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public required string Country { get; set; }
    }
}
