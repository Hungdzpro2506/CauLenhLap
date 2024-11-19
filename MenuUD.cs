using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MenuUD
    {
        static void Main(string[] args)
        {
            int Choice;
            do {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                Choice = Int32.Parse(Console.ReadLine());
                //
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle:");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square:");
                        for (int i = 0; i < 6; i++) // Lặp 6 lần để in hình vuông 6x6
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Draw the rectangle:");
                        for (int i = 0; i < 3; i++) // Lặp 3 lần để in hình chữ nhật 3x6
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            } while (Choice != 0);
        }
    }
}
