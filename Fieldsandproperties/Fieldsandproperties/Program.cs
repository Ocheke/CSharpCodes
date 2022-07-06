// See https://aka.ms/new-console-template for more information
namespace Fieldsandproperties
{
    class Program
    {
        static void Main(String[] args)
        {
            Car cars = new Car();
            cars.SpeedProperty = 256569870;
            cars.WheelsProperty = 56798677;
            cars.Color = "blue";

            Console.WriteLine(cars.SpeedProperty);
            Console.WriteLine(cars.WheelsProperty);
            Console.WriteLine(cars.Color);

        }
    }
}