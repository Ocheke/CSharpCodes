// See https://aka.ms/new-console-template for more information

namespace StaticModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();


            Console.WriteLine(Car.NumberofCars);

            Car.Carspeed();
        }
    }
}