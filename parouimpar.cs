using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Par ou Ímpar ===");

        int numero;

        Console.Write("Digite um número inteiro: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é PAR.");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR.");
        }
    }
}