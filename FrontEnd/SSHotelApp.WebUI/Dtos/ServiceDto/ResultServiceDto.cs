namespace SSHotelApp.WebUI.Dtos.ServiceDto
{
    public class ResultServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceIcon { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
