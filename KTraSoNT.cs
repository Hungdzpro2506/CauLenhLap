using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class KTraSoNT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 so nguyen: ");
            int Num;
            Num= Convert.ToInt32(Console.ReadLine());
            if (Num < 2) {
                Console.WriteLine("khong phai so nguyen to");
            }
            else
            {
                int i = 2;
                bool Ktra = true;
                while (i <= Math.Sqrt(Num))
                {
                    if (Num % i == 0)
                    {
                        Ktra = false;
                        break;
                    }
                    i++;
                   
                }
                if (Ktra)
                {
                    Console.WriteLine(Num + " La so Nguyen to");
                }
                else
                {
                    Console.WriteLine(Num + " khong phai so nguyen to");
                }
            }
        }
    }
}
