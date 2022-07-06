// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CarWork car1 = new CarWork();
            car1.Name = "Range Rover";
            car1.Color = "Grey";
            car1.Size = "50ht-100wt";

            
            CarWork car2 = new CarWork("Honda", "black","50ht-200wt");

        }
    }
}