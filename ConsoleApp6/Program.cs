using System;
using System.IO;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (!Directory.Exists(@"C:\Users\User\Desktop\Files"))
            {
                Directory.CreateDirectory(@"C:\Users\User\Desktop\Files");
            }
            if (!File.Exists(@"C:\Users\User\Desktop\Files\Database.json"))
            {
                File.Create(@"C:\Users\User\Desktop\Files\Database.json");
            }

            //bool check = true;
            
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.Get employee by id");
                Console.WriteLine("3.Remove employee");
                Console.WriteLine("0.Quit");

            

        }
    }
}
