using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("userID") != null)
            {
                return View();
            }

            return RedirectToAction("Login", "Account", new { area = "" });
        }
    }
}
