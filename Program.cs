using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade fibona = new Recursividade();
            //Fibonnaci:
            //Usaremos uma sequência de 0,2,8
            Console.WriteLine("Fibonacci:");
            fibona.Sequencia(0,2,8);
            //Fatoração:
            Console.WriteLine("Fatorial:");
            Console.WriteLine(fibona.Fatorar(6));
        }
    }
}
