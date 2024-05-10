using System;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cores = "";
            string cor1, cor2, cor3;

            Console.WriteLine("Escreva tres cores com espaço");
            cores = Console.ReadLine();
            cor1 = cores.Split(" ")[0];
            cor2 = cores.Split(" ")[1];
            cor3 = cores.Split(" ")[2];
            Console.WriteLine($"{cor1}, {cor2}, {cor3}");
        }
    }
}
