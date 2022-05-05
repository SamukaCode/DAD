using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Digite o 1° ponto flutuante:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° ponto flutuante:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3° ponto flutuante:");
            z = double.Parse(Console.ReadLine());

            // a
            double a = (x * z) / 2;
            Console.WriteLine($"Triângulo: {a:F3}");

            // b
            double b = 3.14159 * z * z;
            Console.WriteLine($"Círculo: {b:F3}");

            // c
            double c = ((x + y) * z) / 2;
            Console.WriteLine($"Trapézio: {c:F3}");

            // d
            double d = y * y;
            Console.WriteLine($"Quadrado: {d:F3}");

            // e
            double e = x * y;
            Console.WriteLine($"Retângulo: {e:F3}");

        }
    }
}
