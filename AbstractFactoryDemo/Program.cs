namespace AbstractFactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory1 = new Electriccar();
            IBMW car1= carFactory1.MakeBMWCar();
            car1.Start();

            ICarFactory carFactory2 = new Electriccar();
            ITesla car2 = carFactory2.MakeTeslaCar();
            car2.Start();

            ICarFactory carFactory3 = new GasolineCar();
            IBMW car3 = carFactory3.MakeBMWCar();
            car3.Start();

            ICarFactory carFactory4 = new GasolineCar();
            ITesla car4 = carFactory4.MakeTeslaCar();
            car4.Start();
        }
    }
}
