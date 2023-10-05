using System;

namespace Aula_05_10_23_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;

            Console.Write("Digite um número: ");
            n1 = float.Parse(Console.ReadLine());

            if (n1 > 10)
            {
                Console.WriteLine("Seu número é maior que 10!!!");
            }                
        }
    }
}
