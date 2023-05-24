using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap vao 3 so nguyen:");
            Console.WriteLine("Nhap so nguyen thu 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen thu 2");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu 3");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("|So nguyen 1|So nguyen 2|So nguyen3");
            Console.WriteLine("| {0} | {1} | {2}  |", a, b, c);
            Console.ReadLine();
        }
    }
}
