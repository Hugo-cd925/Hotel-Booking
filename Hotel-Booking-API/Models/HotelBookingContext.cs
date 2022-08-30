using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_API.Models
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext(DbContextOptions<HotelBookingContext> options) : base(options) { }
        public DbSet <Reservation> Reservation { get; set; }
        public DbSet <RoomType> RoomType { get; set; }
    }
}
