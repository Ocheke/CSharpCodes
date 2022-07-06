using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal class Car
    {
        public static int NumberofCars;

        public Car()
        {
            NumberofCars++;
        }

         public static void Carspeed()
        {
            Console.WriteLine("The race has started");
        }
    }
}
