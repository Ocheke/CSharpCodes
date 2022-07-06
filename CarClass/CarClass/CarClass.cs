using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class CarWork
    {
        public string Name;
        public string Color;
        public string Size;


        public CarWork(string name, string col, string siz)
        {
            Name = name;
            Color = col;
            Size = siz;
        }

        public CarWork()
        {

        }
    }
}
