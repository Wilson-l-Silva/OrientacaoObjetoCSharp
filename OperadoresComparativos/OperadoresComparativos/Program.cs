using System;

namespace OperadoresComparativos
{
    public class Program
    {
        static bool VerificarMaiorMenor(int num1, int num2)
        {
            var retorno = num1 > num2;

            return retorno;
        }

        static void Main(string[] args)
        {
            var numero = VerificarMaiorMenor(1 , 2);
        }
    }


}
