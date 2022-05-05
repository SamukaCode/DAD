using System;

namespace Ex4.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            if ((a == 0) || (b * b - 4 * a * c <= 0))
            {
                Console.WriteLine("Impossível calcular!");
            }
            else
            {
                double x1 = ((b * -1) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                double x2 = ((b * -1) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
    }
}
