using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[100, 100];
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} * {1} = {2}\t ", j, i, i * j);
                    // if (j == 10) Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
