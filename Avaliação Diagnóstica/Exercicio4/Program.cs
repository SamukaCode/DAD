using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, ht;
            double vh,sal;
            Console.WriteLine("Digite o número do funcionário: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas do funcionário: ");
            ht = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que o funcionário recebe por hora: ");
            vh = int.Parse(Console.ReadLine());
            sal = ht * vh;
            Console.WriteLine($"O funcionário de número {num} tem como salário R${sal:F2}.");

        }
    }
}
