using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Verificação de Maioridade ===");

        int idade;

        Console.Write("Digite sua idade: ");
        while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
        {
            Console.Write("Idade inválida. Digite novamente: ");
        }

        if (idade >= 18)
        {
            Console.WriteLine("Usuário maior de idade.");
        }
        else
        {
            Console.WriteLine("Usuário menor de idade.");
        }
    }
}