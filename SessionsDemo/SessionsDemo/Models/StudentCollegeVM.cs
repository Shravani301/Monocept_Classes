using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionsDemo.Models
{
    public class StudentCollegeVM
    {
        public List<Student> Students {  get; set; }
        public List<College> Colleges { get; set; }
    }
}