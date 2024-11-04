namespace DelegatesDemoWithCallbackFunction
{
    internal class Program
    {
        delegate void DMyDelegate(string name);
        static void Main(string[] args)
        {
            Display(PrintName);
            Display(PrintAge);
            Display((name) => Console.WriteLine("Inside lambda function"));
            Display(delegate (string name)
            {
                Console.WriteLine("Inside the Delegate inline function");
            });
        }
        static void Display(DMyDelegate fptr)
        {
            Console.WriteLine("Inside the Polymorphic with Call back function");
            fptr("Delegates");
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, Inside the printName function: "+name);
        }
        static void PrintAge(string name)
        {
            Console.WriteLine("Inside PrintAge function: "+name);
        }
    }
}
