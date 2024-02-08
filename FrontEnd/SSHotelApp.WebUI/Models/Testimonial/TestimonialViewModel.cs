namespace SSHotelApp.WebUI.Models.Testimonial
{
    public class TestimonialViewModel
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
