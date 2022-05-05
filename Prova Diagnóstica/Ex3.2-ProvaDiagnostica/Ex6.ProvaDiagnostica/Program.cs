using System;

namespace Ex6.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d=0,f= 0;
            Console.WriteLine("Quantos números serão lidos?");
            int a = int.Parse(Console.ReadLine());
            for(int b=0;b<a;b++)
            {
                Console.WriteLine($"Digite o {b + 1}° número: ");
                double h = double.Parse(Console.ReadLine());
                if (h > 0 && h < 20)
                {
                    d++;
                }
                else
                {
                    f++;
                }   
            }
            Console.WriteLine($"{d} in");
            Console.WriteLine($"{f} out");
        }
    }
}
