using System;

namespace ConversaoImplicitaExplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 2.5F; // 4 bytes
            double b = a; // 8 bytes

            double c = 45.5;
            float d = (float) c;

            Console.WriteLine(b);
        }
    }
}
