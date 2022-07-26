using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CurrentClass { get; set; }
        public double ResultAverage { get; set; }


        public Student(string first, string surn, string current, double result)
        {
            FirstName = first;
            Surname = surn;
            CurrentClass = current;
            ResultAverage = result;
        }

    }
}
