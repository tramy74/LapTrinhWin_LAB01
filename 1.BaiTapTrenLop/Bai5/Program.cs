using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = Int32.Parse(Console.ReadLine());
            int r = Int32.Parse(Console.ReadLine());
            for(int i=1; i<=d; i++)
            {
                for(int j=1; j<=r; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
