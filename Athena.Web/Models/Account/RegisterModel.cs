using System;
using System.ComponentModel.DataAnnotations;

namespace Athena.Web.Models.Account
{
    public class RegisterModel : BaseModel
    {
        [Required]
        public String Username { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public String ConfirmPassword { get; set; }

        [Required]
        public String Email { get; set; }
    }
}