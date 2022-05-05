using System;

namespace Ex2.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {r * r * 3.14159:F4}");
        }
    }
}
