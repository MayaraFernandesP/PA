using System;

namespace Aula_05_10_23_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;

            Console.WriteLine("Digite o seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario < 3.000)
            {
                Console.WriteLine($"O seu reajuste é: {salario+( salario*50/100) }");
            }

            else if (salario > 3.000 && <= 7.000)
            {
                Console.WriteLine($"O seu reajuste é: {salario + (salario * 20 / 100)}");
            }

            else if (salario > 7.000 && <=10.000)

        }
    }
}
