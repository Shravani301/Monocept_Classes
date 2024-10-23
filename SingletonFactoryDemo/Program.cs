namespace SingletonFactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ICarFactory bmwFactory = BmwFactory.GetInstance();
            ICar bmw = bmwFactory.MakeCar();
            bmw.Start();
            ICarFactory bmwFactory1 = BmwFactory.GetInstance();
            ICar bmw1 = bmwFactory1.MakeCar();
            bmw1.Start();

            Console.WriteLine(bmwFactory.GetHashCode());
            Console.WriteLine(bmwFactory1.GetHashCode());


            ICarFactory teslaFactory = TeslaFactory.GetInstance();
            ICar tesla = teslaFactory.MakeCar();
            tesla.Start();
        }
    }
}
