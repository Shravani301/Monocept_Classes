using LSPSolution.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Models
{
    internal class Ostrich : INonFlyable
    {
        public void GetColor()
        {
            Console.WriteLine("Ostrich color is brown");
        }

        public void GetHeight()
        {
            Console.WriteLine("Ostrich height is 1.5m ");
        }

        public void Walk()
        {
            Console.WriteLine("OStrich can Walk");
        }
    }
}
