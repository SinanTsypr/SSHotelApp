﻿using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
