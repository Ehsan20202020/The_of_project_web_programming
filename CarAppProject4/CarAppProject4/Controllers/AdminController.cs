using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAppProject4.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
       
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}
