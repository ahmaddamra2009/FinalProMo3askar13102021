using FinalProMo3askar13102021.Data;
using FinalProMo3askar13102021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProMo3askar13102021.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppDbContext db;
        public AccountController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Register()
        {

            ViewBag.AllRoles = new SelectList(db.Roles.ToList(), "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);

        }

        // Login Methods

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var lgn = db.Users.Where(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password));
            if (lgn.Any())
            {
                HttpContext.Session.SetString("myName", user.UserName);
                HttpContext.Session.SetString("userID", lgn.FirstOrDefault().UserId.ToString());
                return RedirectToAction("Index", "Dashboard",new { area= "Administrator" });
            }
            ViewBag.err = "Invalid User / password";
            return View(user);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account", new { area = "" });
        }

    }
}
