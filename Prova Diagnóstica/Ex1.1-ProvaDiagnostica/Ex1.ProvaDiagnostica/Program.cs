using System;

namespace Ex1.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, num1, num2;
            float v1, v2;

            Console.WriteLine("Digite o código da peça 1: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de peças 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de cada peça 1: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da peça 2: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de peças 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de cada peça 2: ");
            v2 = int.Parse(Console.ReadLine());

            // Operação

            Console.WriteLine($"Total a pagar: R${num1 * v1 + num2 * v2:F2}");

        }
    }
}
