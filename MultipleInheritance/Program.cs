using MultipleInheritance.Models;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Display();
            child.Eat();

            Boy boy = new Child();
        }
    }
}
