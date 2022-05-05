using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qnt1, qnt2;
            double v1, v2, vPag;
            Console.WriteLine("Insira o código da peça 1: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças de código {0} (peça 1): ",cod1);
            qnt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário da peça 1: ");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o código da peça 2: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças de código {0} (peça 2): ", cod2);
            qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário da peça 2: ");
            v2 = double.Parse(Console.ReadLine());
            vPag = (qnt1 * v1) + (qnt2 * v2);
            Console.WriteLine($"Valor a pagar: R${vPag:F2}");

        }
    }
}
