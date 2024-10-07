using InterfaceAndAbstract.Models;

namespace InterfaceAndAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bike bike = new Bike();
            bike.Move();

            Truck truck = new Truck();  
            truck.Move();
            
            
            Console.WriteLine("\nCalling Move method with the Vehicle obj ref");
            Print(new Car());
            Print(new Bike());
            Print(new Truck());

            Console.WriteLine("\nCalling Move method with the IMovable obj ref");
            PrintMove(new Car());
            PrintMove(new Bike());
            Print(new Truck());

        }
        public static void Print(Vehicle vehicle)
        { 
            vehicle.Move();
        }
        public static void PrintMove(IMovable movable)
        {
            movable.Move();
        }
    }
}
