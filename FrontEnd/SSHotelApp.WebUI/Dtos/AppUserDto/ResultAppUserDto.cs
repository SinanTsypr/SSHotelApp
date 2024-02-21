using SSHotelApp.EntityLayer.Concrete;

namespace SSHotelApp.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string? Country { get; set; } = null!;
        public string? Gender { get; set; } = null!;
        public string? WorkDepartment { get; set; }
        public int WorkLocationId { get; set; }
    }
}
