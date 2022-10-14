using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            if (number < 2) IsPrime = false;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("So nguyen to.");
            }
            else
            {
                Console.Write("Khong la so nguyen to.");
            }
            Console.ReadKey();
        }
    }
}
