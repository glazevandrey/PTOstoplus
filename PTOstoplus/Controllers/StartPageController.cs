using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTOstoplus.Controllers
{
    public class StartPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
