using System;

class Program
{
    static void Main()
    {
        double celsius;

        Console.Write("Digite a temperatura em Celsius: ");

        while (!double.TryParse(Console.ReadLine(), out celsius))
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C equivalem a {fahrenheit:F2}°F");
    }
}