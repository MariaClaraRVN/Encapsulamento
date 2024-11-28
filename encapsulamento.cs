using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar o nome da pessoa
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        // Solicitar o ano de nascimento da pessoa
        Console.Write("Digite o seu ano de nascimento: ");
        int anoNascimento;

        // Verificar se o valor inserido é um número válido
        while (!int.TryParse(Console.ReadLine(), out anoNascimento))
        {
            Console.Write("Ano inválido. Por favor, digite um número válido para o ano de nascimento: ");
        }

        // Calcular a idade
        int anoAtual = DateTime.Now.Year;
        int idade = anoAtual - anoNascimento;

        // Exibir a idade
        Console.WriteLine($"{nome}, você tem {idade} anos.");
    }
}
