using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ColleageCourse.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("house/profile")]
        public IActionResult Profile()
        {
            ViewBag.Title = "Agent Profile";
            return View();
        }
    }
}