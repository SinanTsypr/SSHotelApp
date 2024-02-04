using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
