using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string SocialMedia1 { get; set; } = null!;
        public string SocialMedia2 { get; set; } = null!;
        public string SocialMedia3 { get; set; } = null!;
    }
}
