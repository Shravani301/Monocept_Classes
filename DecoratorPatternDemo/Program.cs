namespace DecoratorPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService car = new CarInspection();

            ICarService carWithOilChange = new OilChange(car);

            ICarService carWithAllServices = new WheelAlign(carWithOilChange);

            Console.WriteLine("Total Car Service Cost: " + carWithAllServices.GetCost());

        }
    }
}
