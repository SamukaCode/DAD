using System;

namespace Ex3.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto: ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do item comprado: ");
            int qnt = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    Console.WriteLine($"Total: R${16 * qnt:F2}");
                    break;
                case 2:
                    Console.WriteLine($"Total: R${25 * qnt:F2}");
                    break;
                case 3:
                    Console.WriteLine($"Total: R${20 * qnt:F2}");
                    break;
                case 4:
                    Console.WriteLine($"Total: R${6.5 * qnt:F2}");
                    break;
                case 5:
                    Console.WriteLine($"Total: R${8 * qnt:F2}");
                    break;
            }
        }
    }
}
