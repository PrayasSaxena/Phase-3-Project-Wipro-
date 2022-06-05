using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "password"), MinLength(8, ErrorMessage = "Minimum length is 8 chars")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

}