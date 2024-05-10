using System;

namespace TiposPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool completo = false;
            //char genero = 'F';
            //char letra = '\u0041';
            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 214748364;
            //long n4 = 2147483648L;
            //float n5 = 4.5f;
            //double n6 = 4.5;
            //// string não é considerado um tipo basico no c#
            //string nome = "Maria Green";
            //// objeto generico (toda classe em C# é sublcasse de object)
            //object obj1 = "Wilson Lima";
            //object obj2 = 5.4;

            //// valores minimos
            //int n8 = int.MinValue;
            //int n9 = int.MaxValue;
            //sbyte n10 = sbyte.MinValue;
            //decimal n11 = decimal.MaxValue;

            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(completo);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            int a = 10;
            int b = a;

            ++a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
