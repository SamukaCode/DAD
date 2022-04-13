using System;

namespace Exercicio_3_Calcula_Diferenca_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;
            Console.WriteLine("Insira o valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de C:");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de D:");
            D = int.Parse(Console.ReadLine());
            diferenca = A * B - C * D;
            Console.WriteLine($"O valor da diferença é:{diferenca}");
        }
    }
}
