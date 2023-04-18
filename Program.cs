using System;

namespace SomaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números a serem lidos (entre 3 e 10):");
            int qtdNumeros = int.Parse(Console.ReadLine());

            if (qtdNumeros < 3 || qtdNumeros > 10)
            {
                Console.WriteLine("Quantidade inválida de números!");
                return;
            }

            int soma = 0;
            for (int i = 1; i <= qtdNumeros; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }

            double media = (double)soma / qtdNumeros;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
        }
    }
}
