namespace MathDelegate
{
    internal class Program
    {
        delegate void dMyDelegate(int num1, int num2);
        static void Main(string[] args)
        {

            dMyDelegate delObj = Add;
            delObj += Sub;
            delObj += Mul;
            delObj += Div;
            delObj(20, 10);

        }
        static void Add(int num1, int num2)
        {
            Console.WriteLine($"Addition of ({num1},{num2}) numbers is:{num1+num2}");
        }
        static void Sub(int num1, int num2)
        {
            Console.WriteLine($"Subtraction of ({num1},{num2}) numbers is:{num1 - num2}");
        }
        static void Mul(int num1, int num2)
        {
            Console.WriteLine($"Multiplication of ({num1},{num2}) numbers is:{num1 * num2}");
        }
        static void Div(int num1, int num2)
        {
            Console.WriteLine($"Divison of ({num1},{num2}) numbers is:{num1 / num2}");
        }
    }
}
