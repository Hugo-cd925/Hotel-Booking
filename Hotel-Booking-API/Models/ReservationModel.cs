using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Booking_API.Models
{
    public class Reservation
    {
        public int Id { get; set; }
		string guestEmail { get; set; }
		string adminEmail { get; set; }
		DateTime checkInDate { get; set; }
		//float Total = numberofNights * Rate;
	   int numberofNights { get; set; }
		float managerSpecial { get; set; } = 0;
		[ForeignKey("roomType")]
		RoomType roomType { get; set; }
		int roomTypeId { get; set; }
	}
}
