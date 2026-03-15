using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora Simples ===");

        double n1, n2;

        Console.Write("Digite o primeiro número: ");
        while (!double.TryParse(Console.ReadLine(), out n1))
        {
            Console.Write("Entrada inválida. Digite novamente: ");
        }

        Console.Write("Digite o segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out n2))
        {
            Console.Write("Entrada inválida. Digite novamente: ");
        }

        Console.Write("Digite a operação (+ - * /): ");
        string operacao = Console.ReadLine();

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {n1 + n2}");
                break;

            case "-":
                Console.WriteLine($"Resultado: {n1 - n2}");
                break;

            case "*":
                Console.WriteLine($"Resultado: {n1 * n2}");
                break;

            case "/":
                if (n2 == 0)
                    Console.WriteLine("Erro: divisão por zero.");
                else
                    Console.WriteLine($"Resultado: {n1 / n2}");
                break;

            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}