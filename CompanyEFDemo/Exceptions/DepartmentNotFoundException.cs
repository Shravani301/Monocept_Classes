﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFDemo.Exceptions
{
    internal class DepartmentNotFoundException:Exception
    {
        public DepartmentNotFoundException(string message):base(message)
        { }
    }
}
