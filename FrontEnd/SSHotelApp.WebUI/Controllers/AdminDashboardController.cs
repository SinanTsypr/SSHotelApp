using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
