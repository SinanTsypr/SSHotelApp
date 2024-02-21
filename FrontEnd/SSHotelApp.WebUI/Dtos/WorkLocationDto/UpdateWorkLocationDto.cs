namespace SSHotelApp.WebUI.Dtos.WorkLocationDto
{
    public class UpdateWorkLocationDto
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; } = null!;
        public string WorkLocationCity { get; set; } = null!;
    }
}
