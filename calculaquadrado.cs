using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Digite um número: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Digite novamente: ");
        }

        int resultado = CalcularQuadrado(numero);

        Console.WriteLine($"O quadrado de {numero} é {resultado}");
    }

    static int CalcularQuadrado(int numero)
    {
        return numero * numero;
    }
}