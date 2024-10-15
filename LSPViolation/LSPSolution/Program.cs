using LSPSolution.Helpers;
using LSPSolution.Models;

namespace LSPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            PrintFlyable(sparrow);
            Crow crow = new Crow();
            PrintFlyable(crow);
            Ostrich ostrich = new Ostrich();
            ostrich.Walk();
            ostrich.GetHeight();
            ostrich.GetColor();
        }
        public static void PrintFlyable(IFlyable flyable)
        {
            flyable.Fly();
            flyable.Walk();
            flyable.GetColor();
        }
    }
}
