namespace DelegatesDemo
{
    internal class Program
    {
        delegate void DMyDelegate(int number);
        static void Main(string[] args)
        {
            int value1 = 10;
            Console.WriteLine("Delegates Demo with Unicast:");
            DMyDelegate delobj = Square;
            delobj(value1); 
            delobj = Cube;
            delobj(value1);
            delobj+=Square;
            Console.WriteLine($"Delagtes Demo with MultiCase");
            delobj(value1);

        }
        static void Square(int number)
        {
            Console.WriteLine($"Square of {number} is:{Math.Pow(number, 2)}");
        }
        static void Cube(int number)
        {
            Console.WriteLine($"Cube of {number} is:{Math.Pow(number,3)}");
        }

    }
}
