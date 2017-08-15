using Athena.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Athena.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}