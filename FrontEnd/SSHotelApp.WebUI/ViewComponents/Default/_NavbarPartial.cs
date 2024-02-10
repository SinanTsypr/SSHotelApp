using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebUI.ViewComponents.Default
{
    public class _NavbarPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
