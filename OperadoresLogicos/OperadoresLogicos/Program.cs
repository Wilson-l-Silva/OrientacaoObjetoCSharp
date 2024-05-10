using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Escreva um numero inteiro negativo ou positivo");

            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Positivo");
            }

        }
    }
}
