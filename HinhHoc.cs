using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacLoaiHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập lựa chọn của bạn: ");
            int LuaChon = Int32.Parse(Console.ReadLine());
            switch (LuaChon)
            {
                case 1:
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0;j<6; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();// xuống dòng
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 6; i++)
                    {
                        for(int j = 1;j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();// xuống dòng
                    }
                    
                    break;
                case 3:
                    for(int i = 6; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();// xuống dòng
                    }
                    break;
                case 4:
                    Console.WriteLine("EXit");
                    break;
                default: Console.WriteLine("chon 1-4");
                    break;
            }
        }
    }
}
