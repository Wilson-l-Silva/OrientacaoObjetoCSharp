using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestandoIniciacaoMetodoConstrutorClasse;
using TestandoIniciacaoMetodoConstrutorClasse.Model;

namespace Teste
{
    class ExecutaTeste
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número Inteiro:");

            VerificadorParImpar num = new VerificadorParImpar(int.Parse(Console.ReadLine()));

          var teste =  num.CalculaNumeroParImpar();          
            //num.Numero = Int32.Parse(Console.ReadLine());


        }
    }
}
