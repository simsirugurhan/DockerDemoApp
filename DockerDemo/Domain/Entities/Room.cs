namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public required string Number { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }
}
