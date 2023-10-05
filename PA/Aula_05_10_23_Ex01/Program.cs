using System;

namespace Aula_05_10_23_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            string operador;

            Console.Write("Digite o primeiso número: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            operador = Console.ReadLine();

            if (operador=="+")
            {
                Console.WriteLine($"A soma é: {n1 + n2}");
            }

            else if (operador=="-")
            {
                Console.WriteLine($"A subtração é: {n1 - n2}");
            }

            else if (operador=="*")
            {
                Console.WriteLine($"A multiplicação é: {n1 * n2}");
            }

            else
            {
                Console.WriteLine($"A divisão é: {n1 / n2}");
            }
        }
    }
}
