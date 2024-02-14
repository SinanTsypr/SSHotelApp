namespace SSHotelApp.WebUI.Dtos.GuestDto
{
    public class ResultGuestDto
    {
        public int GuestId { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
