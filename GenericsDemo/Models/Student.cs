﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }
        public Student(int id,string name, double marks)
        {
            Id= id;
            Name= name;
            Marks= marks;
        }
        public override string ToString()
        {
            return $"Student ID:{Id}\n" +
                $"Student Name:{Name}\n" +
                $"Student Marks:{Marks}\n"; 
        }
    }
}
