﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public List<Student> StudentList { get; set; }
    }
}
