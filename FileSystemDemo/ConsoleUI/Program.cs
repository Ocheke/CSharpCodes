using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string rootPath = @"E:\User\System\source";
            //string[] dirs = Directory.GetDirectories(rootPath);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            bool directoryExist = Directory.Exists(@"E:\User\System\source");
            if (directoryExist)
            {
                Console.WriteLine("Directory exists.");
            }
            else
            {
                Console.WriteLine("Directory does not exists.");
            }
        }
    }
}
