// See https://aka.ms/new-console-template for more information

namespace Fieldsandpropertyclasswork
{
    class Program
    {
        static void Main(string[] arg)
        {
            Human man = new Human();
            man.Eyeproperty = 4;
            man.Legproperty = 4;
            man.Teethproperty = 4;
            man.Color = "Fair in complexion";

            Console.WriteLine(man.Eyeproperty);
            Console.WriteLine(man.Legproperty);
            Console.WriteLine(man.Teethproperty);
            Console.WriteLine(man.Color);
        }
    }
}