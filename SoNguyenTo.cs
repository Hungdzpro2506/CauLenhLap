using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            Console.WriteLine("Danh Sach so NT tu 0-100 la: ");
            for (int i = 2;i<=100;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                    
                }
                if (dem == 2) { Console.WriteLine(i); }
                dem = 0;
            }
        }
    }
}
