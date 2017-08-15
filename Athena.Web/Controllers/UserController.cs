using Athena.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Athena.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserStore _userStore;

        public UserController(IUserStore userStore)
        {
            _userStore = userStore;
        }

        [HttpGet]
        [Route("api/users")]
        public IActionResult GetUsers()
        {
            return Json(_userStore.GetAll());
        }

        [HttpPost]
        [Route("api/users")]
        public IActionResult SaveUser([FromBody] User user)
        {
            if (_userStore.Contains(u => u.Username == user.Username)) {
                throw new Exception($"A user with name {user.Username} already exists.");
            }

            _userStore.Save(user);

            return Ok();
        }
    }
}