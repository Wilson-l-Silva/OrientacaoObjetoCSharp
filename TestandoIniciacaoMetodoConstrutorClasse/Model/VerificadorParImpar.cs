using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoIniciacaoMetodoConstrutorClasse.Model
{
   public class VerificadorParImpar
    {
        public int Numero { get; set; }

        public VerificadorParImpar()
        {;
        }
        public VerificadorParImpar(int numero)
        {
            Numero = numero;
        }


        public string CalculaNumeroParImpar()
        {
            int resultado = 0;
            int comparador = 0;
            string mensagem = "";

            resultado = Numero % 2;
            if (resultado == comparador)
            {
                mensagem = "Número informado é par!";
            }
            else
            {
                mensagem = "Número informado é impar!";
            }

            return mensagem;
        }

    }
}
