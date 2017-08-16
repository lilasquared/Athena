using Athena.Core;
using Athena.Web.Extensions;
using Athena.Web.Models.Account;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Athena.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterModel();
            model.AddMessage(TempData.GetValueOrNull<String>("messages"));

            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                TempData.Store("messages", "Passwords do not match");
                return RedirectToAction("Register");
            }

            var user = new User
            {
                Username = model.Username,
                Password = model.Password,
                Email = model.Email
            };

            return Ok();
        }
    }
}