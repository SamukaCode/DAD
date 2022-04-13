using System;

namespace Exercicio_1_Soma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            Console.WriteLine("Insira dois valores inteiros:");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine($"O valor da Soma é:{soma}");
        }
    }
}
