﻿using System;
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
            for (int i = 10; i < 100; i++)
            {
                if (i % 10 != i / 10)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
