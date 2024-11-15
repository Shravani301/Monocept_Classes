using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginVM.Models
{
    public class Login
    {
        [Required(ErrorMessage = "UserName is must be entered")]
        [MaxLength(5, ErrorMessage = "UserName cannot exceed 5 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}