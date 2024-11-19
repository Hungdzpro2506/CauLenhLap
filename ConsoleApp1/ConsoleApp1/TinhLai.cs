using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TinhLai
    {
        static void Main(string[] args)
        {
            double money;
            Console.WriteLine("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());
            int month ;
            Console.WriteLine("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());
            double intersetRate ;
            Console.WriteLine("Enter annual interest rate in percentage: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset += money * (intersetRate / 100) / 12;
            }
            Console.WriteLine("Total of interset: " + totalInterset);

        }
    }
}
