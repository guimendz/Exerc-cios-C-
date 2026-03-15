using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        SaudarUsuario(nome);
    }

    static void SaudarUsuario(string nome)
    {
        Console.WriteLine($"Olá {nome}, seja bem-vindo ao sistema!");
    }
}