﻿using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            int c = 7;
            int d = 3;
            int e = 9;

            int max = a;

            if (a > max ) max = a;
            if (b > max ) max = b;
            if (c > max ) max = c;
            if (d > max ) max = d;
            if (e > max ) max = e;

            Console.Write("max = ");
            Console.WriteLine(max);
        }
    }
}
