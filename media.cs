using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Cálculo de Média ===");

        double[] notas = new double[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");

            while (!double.TryParse(Console.ReadLine(), out notas[i]))
            {
                Console.Write("Entrada inválida. Digite novamente: ");
            }
        }

        double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

        Console.WriteLine($"Média final: {media:F2}");

        if (media >= 7)
            Console.WriteLine("Aluno aprovado.");
        else
            Console.WriteLine("Aluno em exame.");
    }
}