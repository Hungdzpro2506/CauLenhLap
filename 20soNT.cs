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
            Console.WriteLine("nhap so luong so nguyen to muon in ra: ");
            int Number = Int32.Parse(Console.ReadLine());
            int Count = 0;
            int N = 2;
            int Dem = 0;
            while(Count < Number)
            {
                bool SoNT = true;
                if (N < 2)
                {
                    SoNT = false;
                }
                else
                {
                    int CanBac2N = (int)Math.Sqrt(N);
                    for(int i = 2;i <= CanBac2N;i++)
                    {
                        if(N%i == 0)
                        {
                            SoNT = false;
                            break;
                        }
                    }
                }
                if( SoNT )
                {
                    Count++;
                    Console.WriteLine(N);
                }
                N++;

            }

        }
    }
}
