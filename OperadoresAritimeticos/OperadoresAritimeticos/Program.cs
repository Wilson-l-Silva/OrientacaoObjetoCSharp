﻿using System;

namespace OperadoresAritimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            double n4 = (double) 10 / 8;

            //formula raiz quadrada
            double a = 1, b = -3, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n4);
        }
    }
}
