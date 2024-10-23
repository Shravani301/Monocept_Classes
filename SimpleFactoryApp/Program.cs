using SimpleFactoryApp.Models;

namespace SimpleFactoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car=CarFactory.MakeCar(CarType.TESLA);
            car.Start();
            ICar car1= CarFactory.MakeCar(CarType.BMW);
            car1.Start();
        }
    }
}
