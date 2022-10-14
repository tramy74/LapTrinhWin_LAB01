using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tieuThu = double.Parse(Console.ReadLine());
            double tienDien = 0;
            if (tieuThu >= 1 && tieuThu <= 100)
            {
                tienDien = tieuThu * 5;
            }
            else if (tieuThu <= 150)
            {
                tienDien = 100 * 5 + (tieuThu - 100) * 7;
            }
            else if (tieuThu <= 200)
            {
                tienDien = 100 * 5 + 50 * 7 + (tieuThu - 150) * 10;
            }
            else if (tieuThu <= 300)
            {
                tienDien = 100 * 5 + 50 * 7 + 50 * 10 + (tieuThu - 200) * 15;
            }
            else if (tieuThu >= 301)
            {
                tienDien = 100 * 5 + 50 * 7 + 50 * 10 + 100 * 15 + (tieuThu - 300) * 20;
            }
            Console.WriteLine(tienDien);
        }
    }
}
