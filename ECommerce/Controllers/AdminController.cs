﻿using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
