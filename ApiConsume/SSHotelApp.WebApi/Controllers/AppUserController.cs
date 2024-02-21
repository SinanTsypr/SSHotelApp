using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSHotelApp.BusinessLayer.Abstract;

namespace SSHotelApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TUserListWithWorkLocation();
            return Ok(values);
        }
    }
}
