namespace Hotel_Booking_API.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
    }
}
