using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSHotelApp.BusinessLayer.Abstract;
using SSHotelApp.DataAccessLayer.Concrete;
using SSHotelApp.WebApi.Models;

namespace SSHotelApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appUserService.TUsersListWithWorkLocations();
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(x => new AppUserWorkLocationModel
            {
                Name = x.Name,
                SurName = x.SurName,
                WorkLocationId = x.WorkLocationId,
                WorkLocationName = x.WorkLocation.WorkLocationName,
                City = x.City,
                Country = x.Country,
                Gender = x.Gender,
                ImageUrl = x.ImageUrl,
            }).ToList();
            return Ok(values);
        }
    }
}
