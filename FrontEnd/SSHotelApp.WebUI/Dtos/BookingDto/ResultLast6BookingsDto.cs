namespace SSHotelApp.WebUI.Dtos.BookingDto
{
    public class ResultLast6BookingsDto
    {
        public int BookingId { get; set; }
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; } = null!;
        public string ChildCount { get; set; } = null!;
        public string RoomCount { get; set; } = null!;
        public string SpecialRequest { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
