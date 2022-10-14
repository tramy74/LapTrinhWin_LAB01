using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, max = 0, min = 0, l = 0;
            int[] m = new int[1000];
            bool d = true, p = true;
            int n;
            for (k = 0; p; k++)
            {
                n = Int32.Parse(Console.ReadLine());
                if (d) { max = n; min = n; d = false; }
                if (n == 0) break;
                if (max < n)
                { max = n; }
                if (min > n)
                { min = n; }
                l = l + n;

            }
            Console.WriteLine("Max : " + max);
            Console.WriteLine("Min : " + min);
            Console.WriteLine("Tong day so: " + l);
        }
    }
}
