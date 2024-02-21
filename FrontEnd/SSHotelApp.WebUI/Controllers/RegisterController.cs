using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SSHotelApp.EntityLayer.Concrete;
using SSHotelApp.WebUI.Constants;
using SSHotelApp.WebUI.Dtos.RegisterDto;

namespace SSHotelApp.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                SurName = createNewUserDto.SurName,
                UserName = createNewUserDto.Username,
                City = "Ankara",
                WorkLocationId = RandomNumberGenerator.Generator(),
                ImageUrl = $"/adminweb/images/avatar/{RandomNumberGenerator.Generator()}.jpg"
            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);

            if (result.Succeeded)
                return RedirectToAction("Index", "Login");

            return View();
        }
    }
}
