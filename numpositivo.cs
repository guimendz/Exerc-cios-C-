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

        string resultado = VerificarNumero(numero);

        Console.WriteLine(resultado);
    }

    static string VerificarNumero(int numero)
    {
        if (numero > 0)
            return "Número positivo";

        else if (numero < 0)
            return "Número negativo";

        else
            return "O número é zero";
    }
}