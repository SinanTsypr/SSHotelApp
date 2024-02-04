using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceIcon { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
