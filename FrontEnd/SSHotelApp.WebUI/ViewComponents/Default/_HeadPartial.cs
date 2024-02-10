using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
