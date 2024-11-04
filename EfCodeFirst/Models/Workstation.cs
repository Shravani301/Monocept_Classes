﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst.Models
{
    internal class Workstation
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }

        public Employee Employee { get; set; }

    }
}
