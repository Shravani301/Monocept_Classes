using LSPExample.Models;

namespace LSPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Sparrow sparrow = new Sparrow();
            Print(sparrow);
            Ostrich ostrich = new Ostrich();
            Print(ostrich);
            Crow crow = new Crow();
            Print(crow);
        }
        public static void Print(Bird bird)
        {
            bird.Fly();
            bird.Walk();            
        }
    }
}
