// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string [] args)
        {
            List<Student> students = new List<Student>()
            {
                 new Student("Peace","Obgu","Jss1",50.9),
                 new Student("Patience","Okoh","Sss1",42.5),
                 new Student("Grace","Odeh","Jss3",78.2),
                 new Student("Esther","John","Sss3",20.9),
                 new Student("Juliana","Ekoja","Jss1",99.9),
                 new Student("Joy","Ocheme","Jss3",93.2),
                 new Student("Faith","Subaba","Sss1",62.6),
            };

            //var QuerySyntax = from stu in students
            //                  where stu.CurrentClass == "Jss1"
            //                  select stu;

            //var MethodSyntax = students.Where(stu => stu.CurrentClass == "Jss1");

            //var QuerySyntax = from stu in students
            //                  where stu.CurrentClass == "Jss1" && stu.ResultAverage >= 50
            //                  select stu;

            //var MixedSyntax = (from stu in students
            //                   select stu.ResultAverage).Max();
            //Console.WriteLine(MixedSyntax);



            //var selectQuery = (from stu in students
            //                   select stu).ToList();

            //var selectMethod = students.Select(stu => stu).ToList();

            //var selectQuery = (from stu in students
            //                   select new 
            //                   { 
            //                       CustomName = stu.FirstName,
            //                       Surname = stu.Surname,
            //                       CurrentClass = stu.CurrentClass,
            //                       ResultAverage = stu.ResultAverage

            //                   }).ToList();

            //var selectMethod = students.Select(stu => new
            //{
            //        CustomName = stu.FirstName,
            //        Surname = stu.Surname,
            //        CurrentClass = stu.CurrentClass,
            //        ResultAverage = stu.ResultAverage
            //}).ToList();

            var selectQuery = (from stu in students
                               select stu).ToList();
            var selectMethod = students.Select(stu => stu).ToList();

            var selectResult = students.SelectMany(x => x.FirstName).ToList();


            foreach (var student in selectMethod)
            {
                Console.WriteLine($"Firstname: {student.FirstName}, Surname: {student.Surname}, Class: {student.CurrentClass}, Average: {student.ResultAverage}");
            }



        }
    }
}
