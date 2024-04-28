namespace Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int GuestCount { get; set; }
        public required Customer Customer { get; set; }
        public required Room Room { get; set; }
    }
}
