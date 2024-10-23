namespace FactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ICarFactory carFactory= new BmwFactory();
            ICar car = carFactory.MakeCar();
            car.Start();

            ICarFactory carFactory1 = new TeslaFactory();
            ICar car1 = carFactory1.MakeCar();
            car1.Start();
        }
    }
}
