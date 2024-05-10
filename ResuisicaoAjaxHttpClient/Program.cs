using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResuisicaoAjaxHttpClient
{
    class Program
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public Program(string nome)
        {
            Nome = nome;
        }

        public Program(DateTime data_nascimento) : this()
        {
            Data_Nascimento = data_nascimento;
        }

        public Program()
        {

        }
        static void Main(string[] args)
        {

        }
    }

    class programa2
    {
        Program c = new Program("Wilson");
        Program x = new Program();

        Program a = new Program() {
            Nome = "Aline",
            Idade = 16
        };
    }
}
