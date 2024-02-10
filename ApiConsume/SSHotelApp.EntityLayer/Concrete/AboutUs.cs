using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class AboutUs
    {
        public int AboutUsId { get; set; }
        public string Title1 { get; set; } = null!;
        public string Title2 { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
