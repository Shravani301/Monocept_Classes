using LSPSolution.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Models
{
    internal class Sparrow:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow Can Fly");
        }

        public void GetColor()
        {
            Console.WriteLine("Sparrow color is brown");
        }

        public void Walk()
        {
            Console.WriteLine("Sparrow can Walk");
        }

    }
}
