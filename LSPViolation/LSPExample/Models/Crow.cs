using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Models
{
    internal class Crow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Inside the Crow fly method");
        }

        public override void Walk()
        {
           Console.WriteLine("Inside the Crow walk method");
        }
    }
}
