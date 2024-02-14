using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
