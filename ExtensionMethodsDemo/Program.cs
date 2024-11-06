using ExtensionMethodsDemo.Extensions;

namespace ExtensionMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine(str.ToSnakeCase());
        }
    }
}
