using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double del = b * b - 4 * a * c;
            double x1 = 0, x2 = 0;
            if (del < 0)
            { Console.WriteLine("Phuong trinh vo nghiem."); }
            else if (del == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("x1 = x2 " + x1);
            }
            else
            {
                del = Math.Sqrt(del);
                x1 = (-b - del) / 2 * a;
                x2 = (-b + del) / 2 * a;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
