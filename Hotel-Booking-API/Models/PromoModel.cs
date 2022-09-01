namespace Hotel_Booking_API.Models
{
    public class Promo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PromoCode { get; set; }

        public string? Expiration { get; set; }

        public string Rate { get; set; }

        //If True calc as  Aboslute #
        //If False will be calc as %
        public bool isFlatRate { get; set; }

    }
}
