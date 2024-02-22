namespace SSHotelApp.WebApi.Models
{
    public class AppUserWorkLocationModel
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string WorkLocationName { get; set; } = null!;
        public int WorkLocationId { get; set; }
    }
}
