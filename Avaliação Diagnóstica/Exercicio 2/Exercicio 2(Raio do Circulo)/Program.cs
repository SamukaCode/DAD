using System;

namespace Exercicio_2_Raio_de_um_circulo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio,area;
            Console.WriteLine("Raio:");
            raio = double.Parse(Console.ReadLine());
            area = 3.14159 * (raio * raio);
            Console.WriteLine($"Valor da área: {area:F4}");
        }
    }
}
