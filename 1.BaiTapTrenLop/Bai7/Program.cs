using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=double.Parse(Console.ReadLine());
            double k = (n * (n + 1) * (2 * n + 1)) / 6;
            Console.WriteLine(k);
        }
    }
}
