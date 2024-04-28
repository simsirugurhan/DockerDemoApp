namespace Domain.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Address Location { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
