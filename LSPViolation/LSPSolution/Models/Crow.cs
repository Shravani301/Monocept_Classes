using LSPSolution.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Models
{
    internal class Crow:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Crow Can Fly");
        }

        public void GetColor()
        {
            Console.WriteLine("Crow color is black");
        }

        public void Walk()
        {
            Console.WriteLine("Crow can Walk");
        }

    }
}
