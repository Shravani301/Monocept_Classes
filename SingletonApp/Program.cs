namespace SingletonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService1 = DataService.GetInstance();
            DataService dataService2 = DataService.GetInstance();
            Console.WriteLine(dataService1.GetHashCode());
            Console.WriteLine(dataService2.GetHashCode());

        }
    }
}
