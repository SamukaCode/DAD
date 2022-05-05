using System;

namespace Ex5.ProvaDiagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            do
            {
                Console.WriteLine("Digite a senha:");
                a = Console.ReadLine();
                if (a.Equals("cotil"))
                {
                    Console.WriteLine("Acesso permitido!");
                }
            } while (!a.Equals("cotil")); ;
        }
    }
}
