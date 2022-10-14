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
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Cau a: ");
            if (x > 0)
            {
                Console.WriteLine("3x + sqrt(x) = " + (3 * x + Math.Sqrt(x)));
            }
            else
            {
                Console.WriteLine("e^x + 4 = " + (Math.Exp(x) + 4));
            }
            Console.WriteLine("Cau b:");
            if (x >= 1)
            {
                Console.WriteLine("sqrt(x^2+1) = " + (Math.Sqrt(Math.Pow(x, 2) + 1)));
            }
            else if (x >= -1)
            {
                Console.WriteLine("3x + 5 = " + (3 * x + 5));
            }
            else
            {
                Console.WriteLine("x^2 + 2x - 1 = " + (Math.Pow(x, 2) + x * 2 - 1));
            }
        }
    }
}
