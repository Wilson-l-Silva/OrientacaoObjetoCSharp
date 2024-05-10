using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoIniciacaoMetodoConstrutorClasse
{
    public class Program
    {
        //public Program(string prop)
        //{
        //    prop = "ativo";
        //    Console.WriteLine("É um construtor com parametro");
        //}

        public Program(string teste)
        {
            Console.WriteLine(teste);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo Construtor");
          
        }
    }
}
