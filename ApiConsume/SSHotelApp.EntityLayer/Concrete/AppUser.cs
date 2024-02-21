using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string? Country { get; set; } = null!;
        public string? Gender { get; set; } = null!;
        public string? WorkDepartment { get; set; }
        public int WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; } = null!;
    }
}
