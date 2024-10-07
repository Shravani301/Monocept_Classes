﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLayers.Exceptions
{
    internal class MovieStoreFullException : Exception
    {
        public MovieStoreFullException(string message) : base(message) { }
    }
}
