using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string rootPath = @"C:\Users\Student\Downloads";
                var files = Directory.GetFiles(rootPath, "*.JPG.", SearchOption.AllDirectories);
                string newPath = @"C:\Users\Student\Downloads\PicturesSubfolder";
                Directory.CreateDirectory(newPath);
                string DestinationSubfolder = @"C:\Users\Student\Downloads\PicturesSubfolder\";
                bool imageExists = Directory.Exists(rootPath);
            try
            {
            
                foreach (string file in files)
                {
                    File.Move(file, $"{ DestinationSubfolder}{Path.GetFileName(file)}");

                    if(imageExists)
                    {
                        File.Move(file, $"{ DestinationSubfolder}{Path.GetFileName(file)}");
                    }
                    else
                    {
                        Console.WriteLine("IMAGES NOT FOUND");
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("YOU ARE TAKING AN IMPOSSIBLE STEP....");
                Console.WriteLine("AN IMAGE ALREADY EXIST IN THE FOLDER...");
            }

            Console.ReadLine();
        }
    }
}
  