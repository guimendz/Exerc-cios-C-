using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Soma de Dois Números ===");

        int numero1, numero2;

        Console.Write("Digite o primeiro número: ");
        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }

        Console.Write("Digite o segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }

        int soma = numero1 + numero2;

        Console.WriteLine($"{numero1} + {numero2} = {soma}");
    }
}