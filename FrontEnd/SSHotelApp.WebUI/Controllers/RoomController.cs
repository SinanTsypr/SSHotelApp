using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
