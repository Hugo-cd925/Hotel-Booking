using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Booking_API.Models
{
    public class Reservation
    {
		

		public int Id { get; set; }
		public string GuestEmail { get; set; }
		public string adminEmail { get; set; }
		public DateTime checkInDate { get; set; }
		//float Total = numberofNights * Rate;
	   public int numberofNights { get; set; }
		public float managerSpecial { get; set; } = 0;
		[ForeignKey("roomType")]

		public int roomTypeId { get; set; }
		public RoomType? roomType { get; set; }
		
	}
}
