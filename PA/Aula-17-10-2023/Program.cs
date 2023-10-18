using System;

namespace Aula_17_10_2023
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

            switch(operador)
            {
                case "+":
                    Console.WriteLine($"A soma é: {n1 + n2}");
                    break;

                case "-":
                    Console.WriteLine($"A subtração é: {n1 - n2}");
                    break;

                case "*":
                    Console.WriteLine($"A multiplicação é: {n1 * n2}");
                    break;

                case "/":
                    Console.WriteLine($"A divisão é: {n1 / n2}");
                    break;

                default:
                    Console.WriteLine("Operador Inválido");
                    break;
            }

        }
    
    }
}
