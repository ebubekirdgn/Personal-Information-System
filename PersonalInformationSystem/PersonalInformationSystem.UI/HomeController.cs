﻿using Microsoft.AspNetCore.Mvc;

namespace PersonalInformationSystem.UI
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
