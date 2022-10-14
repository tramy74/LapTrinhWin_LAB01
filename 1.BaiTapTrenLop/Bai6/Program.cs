using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k=Int32.Parse(Console.ReadLine());
            int g=Int32.Parse(Console.ReadLine());
            for(int i=1; i<=k; i++)
            {
                for(int j=1; j<=g; j++)
                {
                    if(i==1||j==1||j==g||i==k)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
