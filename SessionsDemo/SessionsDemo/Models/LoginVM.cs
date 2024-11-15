using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionsDemo.Models
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}