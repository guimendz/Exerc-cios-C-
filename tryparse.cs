using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Teste de Conversão ===");

        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine($"Número válido: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite apenas números.");
        }
    }
}