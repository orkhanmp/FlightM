namespace FlightManagment.Models
{
    public class FlightTicket
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public decimal Price { get; set; }
        public string HotelName { get; set; }
    }

}
