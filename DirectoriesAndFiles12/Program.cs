using System;
using System.IO;

namespace DirectoriesAndFiles12
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\angel\samples";
            Console.WriteLine("Enter directory name:");
            string newDirecoty = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            
            //File.Create($"{rootDirectory}\\{newDirecoty}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirecoty}") && File.Exists($"{rootDirectory}\\{newDirecoty}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exists.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirecoty}");
                File.Create($"{rootDirectory}\\{newDirecoty}\\{fileName}");
            }
        }  

    }
}
