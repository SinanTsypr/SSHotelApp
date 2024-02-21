using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class WorkLocation
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; } = null!;
        public string WorkLocationCity { get; set; } = null!;
        public List<AppUser> AppUsers { get; set; } = new();
    }
}
