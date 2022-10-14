using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m=Int32.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int j = 1; j < m; j++)
            {
                isPrime = true;
                if (j < 2)
                {
                    isPrime = false;
                }
                for (int i = 2; i < j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
